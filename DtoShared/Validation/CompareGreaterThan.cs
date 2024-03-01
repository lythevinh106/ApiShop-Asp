using System.ComponentModel.DataAnnotations;

namespace DtoShared.Validation
{
    public class CompareGreaterThan : ValidationAttribute
    {

        private readonly string _otherPropertyName;

        //private readonly DateTime _dateTime1;
        private readonly string _errorMessage;
        public CompareGreaterThan(string otherPropertyName, string errorMessage)
        {

            _otherPropertyName = otherPropertyName;
            _errorMessage = errorMessage;

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value is DateTime _value)

            {

                var otherPropertyInfo = validationContext.ObjectType.GetProperty(_otherPropertyName);

                if (otherPropertyInfo == null)
                {
                    return new ValidationResult($"Property with name {_otherPropertyName} not found.");
                }

                var otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

                var result = _value.CompareTo((DateTime)otherPropertyValue);

                if (result > 0)
                {
                    return ValidationResult.Success;
                }

                else
                {
                    return new ValidationResult(_errorMessage);

                }

            }





            return ValidationResult.Success;
        }


    }
}
