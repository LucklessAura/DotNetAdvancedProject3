using System;
using System.Collections.Generic;
using System.Linq;
using Project1;
using MimeKit;
using MailKit.Security;

namespace Classes
{
    public class Services : IDisposable
    {
        private Model1Container databaseContext = new Model1Container();
        private bool disposed = false;

        public Services()
        {
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.databaseContext.Dispose();
            }
            this.disposed = true;
        }

        ~Services()
        {
            this.Dispose(true);
        }

        public (List<File>, List<File>) SearchFiles(Dictionary<string, string> proprieties)
        {
            // cauta in baza de date fisierele care corespund proprietatilor din prorpieties
            // returneaza o tupla, primul element din tupla contine fisierele care au proprietatile si au "Deleted" marcat ca false al doilea cele marcate ca "Deleted"
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("D:\\dotnet\\advanced\\Proiect2\\Classes\\Classes\\parameters.txt"))
            {
                writer.WriteLine("Parametrers:");
                foreach (KeyValuePair<string,string>entry in proprieties)
                {
                    writer.WriteLine(entry.Key + "     " + entry.Value);
                }   
            }
            List<File> foundAlive = new List<File>();
            List<File> foundDeleted = new List<File>();
            bool hasAllAtributes = true;
            var queryAlive = from p in databaseContext.Files
                             join q in databaseContext.AditionalFileProprieties on p.FileId equals q.ForeignFileId into complete
                             select new
                             { p, complete };

            if (proprieties.ContainsKey("FileName"))
            {
                string name = proprieties["FileName"];
                queryAlive = queryAlive.Where(cf => cf.p.FileName.Contains(name) || cf.p.FileName.Equals(name));

                proprieties.Remove("FileName");
            }
            if (proprieties.ContainsKey("DateCreated"))
            {
                string date = proprieties["DateCreated"];
                queryAlive = queryAlive.Where(cf => cf.p.DateCreated.Contains(date) || cf.p.DateCreated.Equals(date));

                proprieties.Remove("DateCreated");
            }
            if (proprieties.ContainsKey("Place"))
            {
                string place = proprieties["Place"];
                queryAlive = queryAlive.Where(cf => cf.p.Place.Contains(place) || cf.p.Place.Equals(place));

                proprieties.Remove("Place");
            }
            if (proprieties.ContainsKey("People"))
            {
                List<string> people = proprieties["People"].Split(',').ToList();
                people.ForEach(person =>
                {
                    queryAlive = queryAlive.Where(cf => cf.p.People.Contains(person) || cf.p.People.Equals(person));
                });

                proprieties.Remove("People");
            }
            if (proprieties.ContainsKey("Ocasion"))
            {
                string ocasion = proprieties["Ocasion"];
                queryAlive = queryAlive.Where(cf => cf.p.Ocasion.Contains(ocasion) || cf.p.Ocasion.Equals(ocasion));

                proprieties.Remove("Ocasion");
            }


            var queryDeleted = queryAlive.Where(cf => cf.p.Deleted == true);
            queryAlive = queryAlive.Where(cf => cf.p.Deleted == false);

            queryAlive.ToList().ForEach(item =>
            {
                if (!foundAlive.Contains(item.p))
                {
                    hasAllAtributes = true;
                    foreach (KeyValuePair<string, string> entry in proprieties)
                    {
                        string atributeName = entry.Key;
                        string atributeValue = entry.Value;
                        if (!(item.complete.Any(y => (y.ProprietyName.Equals(atributeName) || y.ProprietyName.Contains(atributeName)) && (y.ProprietyValue.Equals(atributeValue) || y.ProprietyValue.Contains(atributeValue)))))
                        {
                            hasAllAtributes = false;
                        }
                    }
                    if (hasAllAtributes == true)
                    {
                        foundAlive.Add(item.p);
                    }

                }
            }
            );

            queryDeleted.ToList().ForEach(item =>
            {
                if (!foundDeleted.Contains(item.p))
                {
                    hasAllAtributes = true;
                    foreach (KeyValuePair<string, string> entry in proprieties)
                    {
                        string atributeName = entry.Key;
                        string atributeValue = entry.Value;
                        if (!(item.complete.Any(y => (y.ProprietyName.Equals(atributeName) || y.ProprietyName.Contains(atributeName)) && (y.ProprietyValue.Equals(atributeValue) || y.ProprietyValue.Contains(atributeValue)))))
                        {
                            hasAllAtributes = false;
                        }
                    }
                    if (hasAllAtributes == true)
                    {
                        foundDeleted.Add(item.p);
                    }

                }
            }
            );


            return (foundAlive, foundDeleted);

        }

        public void Restore(int fileId)
        {
            // Modifica proprietatea "Deleted" din baza de date a fisierului cu Id-ul "fileId" in "false"
            
            try
            {
                databaseContext.Files.Find(fileId).Deleted = false;
                databaseContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddNewPropriety(File file, string proprietyName, string proprietyValue)
        {
            //adauga o noua coloana in "AdditionalFileProprieties" pentru fisierul dat

            AditionalFilePropriety aditionalFilePropriety = new AditionalFilePropriety
            {
                File = file,
                ProprietyName = proprietyName,
                ProprietyValue = proprietyValue
            };
            databaseContext.AditionalFileProprieties.Add(aditionalFilePropriety);

        }

        public void AddNewFile(Dictionary<string, string> proprieties)
        {
            //adauga un nou fisier in baza de date bazat pe dictionarul de proprietati 

            File file = new File();
            if (proprieties.ContainsKey("FileName"))
            {
                file.FileName = proprieties["FileName"];
                proprieties.Remove("FileName");
            }
            if (proprieties.ContainsKey("DateCreated"))
            {
                file.DateCreated = proprieties["DateCreated"];
                proprieties.Remove("DateCreated");
            }
            if (proprieties.ContainsKey("Place"))
            {
                file.Place = proprieties["Place"];
                proprieties.Remove("Place");
            }
            if (proprieties.ContainsKey("People"))
            {
                file.People = proprieties["People"];
                proprieties.Remove("People");
            }
            if (proprieties.ContainsKey("Ocasion"))
            {
                file.Ocasion = proprieties["Ocasion"];
                proprieties.Remove("Ocasion");
            }
            if (proprieties.ContainsKey("FilePath"))
            {
                file.FilePath = proprieties["FilePath"];
                proprieties.Remove("FilePath");
            }
            file.Deleted = false;
            databaseContext.Files.Add(file);

            foreach (KeyValuePair<string, string> entry in proprieties)
            {
                AddNewPropriety(file, entry.Key, entry.Value);
            }

            databaseContext.SaveChanges();

        }

        public void ModifyFile(int fileId, Dictionary<string, string> proprieties)
        {
            //modifica un fisier existent
            
            File file = databaseContext.Files.Find(fileId);
            if (proprieties.ContainsKey("FileName"))
            {
                file.FileName = proprieties["FileName"];
                proprieties.Remove("FileName");
            }
            if (proprieties.ContainsKey("DateCreated"))
            {
                file.DateCreated = proprieties["DateCreated"];
                proprieties.Remove("DateCreated");
            }
            if (proprieties.ContainsKey("Place"))
            {
                file.Place = proprieties["Place"];
                proprieties.Remove("Place");
            }
            if (proprieties.ContainsKey("People"))
            {
                file.People = proprieties["People"];
                proprieties.Remove("People");
            }
            if (proprieties.ContainsKey("Ocasion"))
            {
                file.Ocasion = proprieties["Ocasion"];
                proprieties.Remove("Ocasion");
            }
            if (proprieties.ContainsKey("FilePath"))
            {
                file.FilePath = proprieties["FilePath"];
                proprieties.Remove("FilePath");
            }

            var query = from q in databaseContext.AditionalFileProprieties where q.ForeignFileId.Equals(fileId) select q;
            query.ToList().ForEach(element =>
            {
                databaseContext.AditionalFileProprieties.Remove(element);
            });

            foreach (KeyValuePair<string, string> entry in proprieties)
            {
                AddNewPropriety(file, entry.Key, entry.Value);
            }

            databaseContext.SaveChanges();
        }

        public Dictionary<string, string> GetFileProprieties(int fileId)
        {
            // gaseste fisierul cu Id-ul fileId in baza de date si ii returneaza un dictionar cu toate proprietatile

            Dictionary<string, string> proprieties = new Dictionary<string, string>();
            var query = from p in databaseContext.Files
                        where p.FileId.Equals(fileId)
                        join q in databaseContext.AditionalFileProprieties on p.FileId equals q.ForeignFileId into complete
                        select new
                        { p, complete };

            query.ToList().ForEach(el =>
            {
                proprieties.Add("FileName", el.p.FileName);
                proprieties.Add("DateCreated", el.p.DateCreated);
                proprieties.Add("People", el.p.People);
                proprieties.Add("Place", el.p.Place);
                proprieties.Add("Ocasion", el.p.Ocasion);
                el.complete.ToList().ForEach(subEl =>
                {
                    proprieties.Add(subEl.ProprietyName, subEl.ProprietyValue);
                });
            });
            return proprieties;
        }

        public bool DeleteFile(int fileId)
        {
            //marcheaza un fisier ca sters in baza de date
            //returneaza true daca operatia a fost realizata cu succes, arunca eceptia mai departe daca nu 
            try
            {
                databaseContext.Files.Find(fileId).Deleted = true;
                databaseContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool DefinitiveDeleteFile(int fileId)
        {
            //sterge definitiv un fisier care este deja marcat ca si sters in baza de date 
            //returneaza true daca operatia a fost realizata cu succes, false altfel
            try
            {
                var query = from q in databaseContext.AditionalFileProprieties where q.ForeignFileId.Equals(fileId) select q;
                query.ToList().ForEach(element =>
                {
                    databaseContext.AditionalFileProprieties.Remove(element);
                });

                var file = databaseContext.Files.Find(fileId);
                databaseContext.Files.Remove(file);
                databaseContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool CopyFilesToPath(string path, List<int> filesId)
        {
            //copiaza fisierele din filesToSave in path, path poate fi un suport extern
            //returneaza true daca operatia a fost realizata cu succes, arunca o exceptie altfel
            try
            {
                var query = from p in databaseContext.Files where filesId.Contains(p.FileId) select p.FilePath;
                query.ToList().ForEach(el =>
                {
                    System.IO.File.Copy(el, path + "\\" + System.IO.Path.GetFileName(el), true);
                });
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool MoveFilesToPath(string path, List<int> filesId)
        {
            //muta fisierele din "filesId" in "path" modificand locatiile in baza de date
            // returneaza true daca a fost efectuata cu succes, arunca o exceptie altfel
            try
            {
                var query = from p in databaseContext.Files where filesId.Contains(p.FileId) select p;
                List<string> paths = new List<string>()

;                query.ToList().ForEach(el =>
                {
                    paths.Add(el.FilePath);
                    System.IO.File.Copy(el.FilePath, path + "\\" + System.IO.Path.GetFileName(el.FilePath));
                    el.FilePath = path + "\\" + System.IO.Path.GetFileName(el.FilePath);
                    
                });

                paths.ForEach(el =>
                {
                    System.IO.File.Delete(el);
                });

                databaseContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async void SendEmail(string to, string from, string subject, string body, List<int> fileIds, string email, string emailPassword)
        {
            //metoda care trimite un mail cu fisierele atasate cu id-ul in "fileIds" catre adresa din variabila "to"
            // ca smtp am folosit cel de la outlook, parametrii de logare sunt cei din "email" si "emailPassword"
            try
            {
                body += "\n From " + from;
                var filePaths = new List<string>();
                var query = from p in databaseContext.Files where fileIds.Contains(p.FileId) select p.FilePath;
                query.ToList().ForEach(el =>
                {
                    filePaths.Add(el);
                });
                var emailBody = new TextPart("plain") { Text = body };
                var multipart = new BodyBuilder();
                multipart.TextBody = body;
                foreach (var item in filePaths)
                {
                    multipart.Attachments.Add(item);
                }
                var message = new MimeMessage
                {
                    Sender = new MailboxAddress(email),
                    Subject = subject,
                };


                message.From.Add(new MailboxAddress(email));


                message.Body = multipart.ToMessageBody();
                message.To.Add(new MailboxAddress(to));
                using (var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    await smtp.ConnectAsync("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                    await smtp.AuthenticateAsync(email, emailPassword);
                    await smtp.SendAsync(message);
                    await smtp.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
