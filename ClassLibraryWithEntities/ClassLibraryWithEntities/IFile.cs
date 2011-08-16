using System;

namespace ClassLibraryWithEntities
{
    public interface IFile<TBlob>
    {
        long ID { get; }
        string Name { get; set; }
        string Extension { get; set; }
        TBlob Tech_BLOB { get; set; }
        DateTime? Date { get; set; }
        long AccessGroupID { get; set; }
    }
}