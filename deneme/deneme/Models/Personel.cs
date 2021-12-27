using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Models
{
    public class Personel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyetinizi seçiniz.")]
        public string Cinsiyet { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC kimlik numarası {2} karakter olmalıdır.")]
        [Required(ErrorMessage = "Lütfen TC kimlik numaranızı giriniz.")]
        public string Tc { get; set; }
        [Required(ErrorMessage = "Lütfen e-mail adresinizi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Lütfen ikametgah belgenizi yükleyiniz.")]
        [DataType(DataType.Upload)]
        public byte[] Ikametgah { get; set; }
        [Required(ErrorMessage = "Lütfen diplomanızı yükleyiniz.")]
        public byte[] Diploma { get; set; }
        [Required(ErrorMessage = "Lütfen hizmet döküm belgenizi yükleyiniz.")]
        public byte[] Hizmetdokum { get; set; }
        [Required(ErrorMessage = "Lütfen askerlik belgenizi yükleyiniz.")]
        public byte[] Askerlik { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime Dogumtarih { get; set; }
        [Required(ErrorMessage = "Lütfen ikametgah adresinizi giriniz.")]
        public string Adres { get; set; }
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Cep telefon numarası {2} karakter olmalıdır.")]
        [Required(ErrorMessage = "Lütfen cep telefon numaranızı giriniz.")]
        public string Tel { get; set; }
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Cep telefon numarası {2} karakter olmalıdır.")]
        [Required(ErrorMessage = "Lütfen ulaşılabilecek 2. cep telefon numarası giriniz.")]
        public string Ikincitel { get; set; }
        [Required(ErrorMessage = "Lütfen başvurmak istediğiniz pozisyonu seçiniz.")]
        public string Pozisyon { get; set; }
        [Required(ErrorMessage = "Lütfen medeni durumunuzu seçiniz.")]
        public string Medenidurum { get; set; }
        [Required(ErrorMessage = "Lütfen iş durumunuzu seçiniz.")]
        public string Isdurumu { get; set; }
        [Required(ErrorMessage = "Lütfen ehliyet belgenizi yükleyiniz.")]
        public byte[] Ehliyet { get; set; }
        [Required(ErrorMessage = "Lütfen fotoğrafınızı .jpg formatında yükleyiniz.")]
        public byte[] Fotograf { get; set; }
        [Required(ErrorMessage = "Lütfen ehliyet sınıfınızı seçiniz.")]
        public string Ehliyetsec { get; set; }
        [Required(ErrorMessage = "Lütfen askerlik durumunuzu seçiniz.")]
        public string Askersec { get; set; }
        [Required(ErrorMessage = "Lütfen adli sicil belgenizi yükleyiniz.")]
        public byte[] Adlisicil { get; set; }
        [Required(ErrorMessage = "Lütfen eğitim durumunuzu seçiniz.")]
        public string Egitimdurumu { get; set; }
        [Required(ErrorMessage = "Lütfen mesleğinizi giriniz.")]
        public string Meslek { get; set; }

        
        


    }
   
}
