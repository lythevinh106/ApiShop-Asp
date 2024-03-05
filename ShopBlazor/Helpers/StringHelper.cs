using DtoShared.Enums;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopBlazor.Helpers
{
    public class StringHelper
    {
        public string ConvertObjectToSearchParam(object _object)
        {
            if (_object != null)
            {
                StringBuilder searchParam = new StringBuilder();

                Type type = _object.GetType();

                for (int i = 0; i < type.GetProperties().Length - 1; i++)
                {
                    string propertyName = type.GetProperties()[i].Name;
                    object propertyValue = type.GetProperties()[i].GetValue(_object);


                    if (propertyValue != null)
                    {
                        if (i == 0 || searchParam.Length == 0)
                        {
                            searchParam.Append($"{propertyName}={propertyValue}");


                        }
                        else
                        {
                            searchParam.Append($"&{propertyName}={propertyValue}");
                        }
                    }

                }




                return searchParam.ToString();
            }


            return "";
        }


        public string formatNumber(decimal number)
        {

            return string.Format("{0:F0}", number) + "-vnd";


        }

        public MarkupString formatStatusOrder(StatusOrder statusOrder)
        {
            switch (statusOrder)
            {
                case StatusOrder.Cancle:
                    return new MarkupString("<span class=\"badge text-bg-secondary\">Đã Hủy</span>");

                case StatusOrder.Success:

                    return new MarkupString("<span class=\"badge text-bg-success\">Thành Công</span>");

                case StatusOrder.Pending:
                    return new MarkupString("<span class=\"badge text-bg-primary\">Chờ Xử Lí</span>");



                default:
                    return new MarkupString("");
            }




        }




        public MarkupString formatStatusPromotion(DateTime dateTimeStart, DateTime dateTimeEnd)
        {

            int result = dateTimeEnd.CompareTo(dateTimeStart);

            switch (result)
            {
                case -1:
                    return new MarkupString("<span class=\"badge text-bg-secondary\">Hết Hạn</span>");

                case 1:

                    return new MarkupString("<span class=\"badge text-bg-success\">Đang Hiệu Lực</span>");


                default:
                    return new MarkupString("<span class=\"badge text-bg-secondary\">Hết Hạn</span>");
            }




        }




        public string GetDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DisplayAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));

            return attribute == null ? value.ToString() : attribute.Name;
        }
    }
}