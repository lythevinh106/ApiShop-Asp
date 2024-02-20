using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Azure;
using System.Web;

namespace Service.ServiceTools.Blob
{
    public class BLobService : IBlob
    {

        private BlobServiceClient _client1Blob;

        private BlobContainerClient _clientWithName;

        public static readonly List<string> ImageExtensions = new List<string> { ".jpg", ".jpeg", ".png" };

        public BLobService(
            IAzureClientFactory<BlobServiceClient> blobClientFactory


            )
        {
            _client1Blob = blobClientFactory.CreateClient("blob1");

            // storage name 
            _clientWithName = _client1Blob.GetBlobContainerClient("azureblobwith3tier");



        }

        public async Task<string> UploadBlobFile(Stream file, string fileName, string contentTypeFile)
        {

            try
            {
                ///create blob instance
                var blobClient = _clientWithName.GetBlobClient($"{Guid.NewGuid()}{fileName}");

                //option

                BlobUploadOptions uploadOptions = new BlobUploadOptions
                {
                    HttpHeaders = new BlobHttpHeaders
                    {
                        ContentType = contentTypeFile
                    }
                };


                var status = await blobClient.UploadAsync(file, uploadOptions);

                return blobClient.Uri.AbsoluteUri;

            }

            catch (Exception ex)
            {
                throw new Exception("Upload Image Failed." + ex.ToString());
            }


        }

        public async Task<string> getBlobFileNameFromUrl(string url)
        {

            string blobUrl = HttpUtility.UrlDecode(url);
            //blobUrl = url.Replace("%", "");


            //     blobUrl = Uri.EscapeDataString(url);

            string[] parts = blobUrl.Split('/');

            string blobName = parts[^1];



            return blobName;



        }

        public async Task<bool> DeleteBlobAsync(string blobFileName)
        {

            bool result = false;


            //79f76309-a511-43ee-a328-633f51aab5a3Screenshot 2024-02-05 191718.png
            BlobClient file = _clientWithName.GetBlobClient(blobFileName);



            if (await file.ExistsAsync())
            {
                result = await file.DeleteIfExistsAsync();
            }
            else
            {
                // Xử lý trường hợp blob không tồn tại
            }









            return result;


        }

        public async Task<Stream> DownLoadBlobAsync(string blobFileName)
        {

            BlobClient file = _clientWithName.GetBlobClient(blobFileName);

            if (await file.ExistsAsync())
            {
                var downloadContent = await file.DownloadAsync();

                return downloadContent.Value.Content;
            }
            else
            {
                throw new FileNotFoundException("File Không tồn tại trên hệ thống");
            }



        }

        public Task<List<string>> ListBlob()
        {
            throw new NotImplementedException();
        }


    }
}
