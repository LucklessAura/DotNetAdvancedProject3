using System.Collections.Generic;
using System.ServiceModel;
using Project1;

namespace WCF
{
    [ServiceContract]
    interface interfaceClasses
    {
        [OperationContract]
        void AddNewFile(Dictionary<string, string> newFile);

        [OperationContract]
        void AddNewPropriety(File file, string proprietyName, string proprietyValue);

        [OperationContract]
        bool CopyFilesToPath(string path, List<int> filesIds);

        [OperationContract]
        bool DefinitiveDelete(int id);

        [OperationContract]
        bool DeleteFile(int id);

        [OperationContract]
        Dictionary<string, string> GetFileProprieties(int id);

        [OperationContract]
        void ModifyFile(int id, Dictionary<string, string> newProprieties);

        [OperationContract]
        bool MoveFilesToPath(string path, List<int> filesId);

        [OperationContract]
        void Restore(int id);

        [OperationContract]
        (List<File>, List<File>) SearchFiles(Dictionary<string, string> proprieties);

        [OperationContract]
        void SendEmail(string to, string from, string subject, string body, List<int> filesIds, string email, string emailPassword);

    }

    [ServiceContract]
    interface IClasses : interfaceClasses
    {

    }


}
