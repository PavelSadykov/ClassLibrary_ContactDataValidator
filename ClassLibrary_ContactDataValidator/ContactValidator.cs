using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary_ContactDataValidator
{
    public static class ContactValidator
    {

        public static bool IsFullNameValid(string fullName)

        {
            // Разрешаем до 5-и слов, разделенных пробелами, каждое слово может начинаться с буквы любого регистра (англ. и русск.)
            return Regex.IsMatch(fullName, @"^([A-Za-zА-Яа-я][A-Za-zА-Яа-я]*\s?){1,5}$");
        }

        public static bool IsAgeValid(string age)
        {
            return Regex.IsMatch(age, @"^\d+$");
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            // Задаем формат телефона: +7(987)654-3210
            return Regex.IsMatch(phoneNumber, @"^\+\d{1,2}\(\d{3}\)\d{3}-\d{4}$");
        }

        public static bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email,
                @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
        }

    }
}
