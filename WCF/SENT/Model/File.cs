//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            this.AditionalFileProprieties = new HashSet<AditionalFilePropriety>();
        }

        [DataMember]
        public int FileId { get; set; }
        [DataMember]
        public string FilePath { get; set; }
        [DataMember]
        public string DateCreated { get; set; }
        [DataMember]
        public string Ocasion { get; set; }
        [DataMember]
        public string People { get; set; }
        [DataMember]
        public string Place { get; set; }
        [DataMember]
        public bool Deleted { get; set; }
        [DataMember]
        public string FileName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<AditionalFilePropriety> AditionalFileProprieties { get; set; }
    }

}