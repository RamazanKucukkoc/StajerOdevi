using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountCategoryError = "Ürünler bir kategoride en fazla 10 tane olamalı";
        public static string ProductNameAlreadyExists="Bu ürün isminde ürün var ve eklenemez";
        public static string CategoryErrorLimetExceed="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered="Kullanıcı kayıt oldu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string CategotryGetAll="Categorilerin Hepsi Listelendi";
    }
}
