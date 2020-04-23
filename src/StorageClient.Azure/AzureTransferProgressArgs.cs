using System;

namespace NSPersonalCloud.StorageClient.Azure
{
    public class AzureTransferProgressArgs : EventArgs
    {
        public AzureTransferProgressArgs(long transferred, long total)
        {
            TransferredBytes = transferred;
            TotalBytes = total;
        }

        public long TransferredBytes { get; }

        public long TotalBytes { get; }
    }
}
