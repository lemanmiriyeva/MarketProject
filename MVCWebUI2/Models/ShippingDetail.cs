namespace Market.MVCWebUI2.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage = "Isim gerekli!")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "Soyad gerekli!")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "E-posta gerekli!")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Sehir gerekli!")]
        public string City { get; set; }
        //[Required(ErrorMessage = "Adres gerekli!")]
        //[MinLength(10,ErrorMessage = "Minimum 10 karakter olmalidir!")]
        public string Address { get; set; }
        //[Range(18,65, ErrorMessage = "Yas gerekli!")]
        public int Age { get; set; }
    }
}
