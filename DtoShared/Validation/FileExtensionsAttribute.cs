using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DtoShared.Validation
{

    public class FileExtensionAttribute : ValidationAttribute
    {
        public string[] _arrayExtensions;

        // Constructor que recibe un parámetro arrayExtensions de tipo Array<string>
        public FileExtensionAttribute(string[] arrayExtensions)
        {
            _arrayExtensions = arrayExtensions;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value is null)
            {
                return ValidationResult.Success;
            }


            if (value is IFormFile file  )

            {
                var extension = Path.GetExtension(file.FileName); //123.jpg

                bool result = _arrayExtensions.Any(x => extension.EndsWith(x));

                if (!result)
                {

                    StringBuilder sb = new StringBuilder();

                    foreach (var item in _arrayExtensions)
                    {
                        sb.Append(item + ",");
                    }
                    // throw new ValidationException("chi chap nhan " + sb.ToString());
                    return new ValidationResult("Chỉ Chấp Nhận Kiểu  " + sb);
                }
            }


            if (value is StreamContent file2)

            {
                var extension = Path.GetExtension(GetFileName(file2)); //123.jpg

                bool result = _arrayExtensions.Any(x => extension.EndsWith(x));

                if (!result)
                {

                    StringBuilder sb = new StringBuilder();

                    foreach (var item in _arrayExtensions)
                    {
                        sb.Append(item + ",");
                    }
                    // throw new ValidationException("chi chap nhan " + sb.ToString());
                    return new ValidationResult("Chỉ Chấp Nhận Kiểu  " + sb);
                }
            }



            return ValidationResult.Success;

        }

        private static string GetFileName(StreamContent content)
        {
            var contentDisposition = content.Headers.ContentDisposition;
            if (contentDisposition != null && contentDisposition.FileName != null)
            {
                return contentDisposition.FileName;
            }

            return string.Empty;
        }
    }



}
