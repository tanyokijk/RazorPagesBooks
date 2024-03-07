using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Services;

public static class SeedData
{
    public static List<Style> GetInitialStyles()
    {
        var romanceNovels = new Style { Name = "Любовні романи" };
        var detective = new Style { Name = "Детектив" };
        var thrillers = new Style { Name = "Трилери" };
        var horror = new Style { Name = "Жахи" };
        var fantasy = new Style { Name = "Фантастика" };
        var comics = new Style { Name = "Комікси" };
        var modernUkrainianprose = new Style { Name = "Сучасна українська проза" };
        var modernForeignprose = new Style { Name = "Сучасна зарубіжна проза" };

        return new List<Style> { romanceNovels, detective, thrillers, horror, fantasy, comics, modernUkrainianprose, modernForeignprose };
    }

    public static List<Publisher> GetInitialPublishers()
    {
        var pm = new Publisher { Name = "РМ" };
        var csd = new Publisher { Name = "Книжковий клуб «Клуб Сімейного Дозвілля»" };
        var bookChef = new Publisher { Name = "Book Chef" };
        var ranok = new Publisher { Name = "Ранок" };
        var lev = new Publisher { Name = "Видавництво Старого Лева" };

        return new List<Publisher> { pm, csd, bookChef, ranok, lev };
    }

    public static List<Book> GetInitialBooks()
    {
        var romanceNovels = new Style { Name = "Любовні романи" };
        var detective = new Style { Name = "Детектив" };
        var thrillers = new Style { Name = "Трилери" };
        var horror = new Style { Name = "Жахи" };
        var fantasy = new Style { Name = "Фантастика" };
        var comics = new Style { Name = "Комікси" };
        var modernUkrainianprose = new Style { Name = "Сучасна українська проза" };
        var modernForeignprose = new Style { Name = "Сучасна зарубіжна проза" };

        var pm = new Publisher { Name = "РМ" };
        var csd = new Publisher { Name = "Книжковий клуб «Клуб Сімейного Дозвілля»" };
        var bookChef = new Publisher { Name = "Book Chef" };
        var ranok = new Publisher { Name = "Ранок" };
        var lev = new Publisher { Name = "Видавництво Старого Лева" };

        var book1 = new Book
        {
            Id = 1,
            Name = "Хімія смерті. Перше розслідування",
            Author = "Саймон Бекетт",
            Publisher = csd,
            Year = 2022,
            Styles = new List<Style> { detective, modernForeignprose },
            Photo = "https://book-ye.com.ua/upload/resize_cache/iblock/195/520_860_1/b51ec4fd_59f7_11ed_8175_0050568ef5e6_a8c9d175_5c48_11ed_8175_0050568ef5e6.jpg",
        };

        var book2 = new Book
        {
            Id = 2,
            Name = "Якби він був зі мною",
            Author = "Лора Новлін",
            Publisher = pm,
            Year = 2023,
            Styles = new List<Style> { romanceNovels, modernForeignprose },
            Photo = "https://book-ye.com.ua/upload/iblock/226/460a3c1e_9b56_11ee_818f_00505684ea69_72348f19_a09f_11ee_8190_00505684ea69.jpg",
        };

        var book3 = new Book
        {
            Id = 3,
            Name = "Смертниці",
            Author = "Тесс Ґеррітсен",
            Publisher = csd,
            Year = 2020,
            Styles = new List<Style> { thrillers, horror },
            Photo = "https://book-ye.com.ua/upload/iblock/db8/fdb92b8e_04c2_11eb_813d_000c29ae1566_3eaaff9c_07ce_11eb_813d_000c29ae1566.jpg",
        };

        var book4 = new Book
        {
            Id = 4,
            Name = "Казка",
            Author = "Стівен Кінг",
            Publisher = csd,
            Year = 2023,
            Styles = new List<Style> { fantasy },
            Photo = "https://book-ye.com.ua/upload/resize_cache/iblock/295/520_860_1/8b93089b_0067_11ee_8184_00505684ea69_19067cb6_0068_11ee_8184_00505684ea69.jpg",
        };

        var book5 = new Book
        {
            Id = 5,
            Name = "Із крові й попелу",
            Author = "Дженніфер Л. Арментраут",
            Publisher = bookChef,
            Year = 2022,
            Styles = new List<Style> { fantasy },
            Photo = "https://book-ye.com.ua/upload/iblock/659/690a15a6_dcd1_11ec_8170_0050568ef5e6_73fc3580_dcd2_11ec_8170_0050568ef5e6.jpg",
        };

        var book6 = new Book
        {
            Id = 6,
            Name = "Пес Патрон та Шкарпетковий монстр",
            Author = "Юліта Ран, Катерина Підлісна",
            Publisher = ranok,
            Year = 2023,
            Styles = new List<Style> { comics },
            Photo = "https://book-ye.com.ua/upload/iblock/633/eaa4f623_cc8b_11ed_8182_00505684ea69_a4277658_cc8c_11ed_8182_00505684ea69.jpg",
        };

        var book7 = new Book
        {
            Id = 7,
            Name = "Я бачу, вас цікавить пітьма",
            Author = "Ілларіон Павлюк",
            Publisher = lev,
            Year = 2023,
            Styles = new List<Style> { modernUkrainianprose },
            Photo = "https://book-ye.com.ua/upload/iblock/244/eff29e86_12de_11eb_813d_000c29ae1566_d681a1c6_12df_11eb_813d_000c29ae1566.jpg",
        };

        var book8 = new Book
        {
            Id = 8,
            Name = "Кривий будиночок",
            Author = "Аґата Крісті",
            Publisher = csd,
            Year = 2024,
            Styles = new List<Style> { detective },
            Photo = "https://book-ye.com.ua/upload/resize_cache/iblock/84a/520_860_1/d9a47f25_2303_11ea_8126_000c29ae1566_f3faaff8_c681_11ee_8192_00505684ea69.jpg",
        };

        var book9 = new Book
        {
            Id = 9,
            Name = "Бійцівський клуб",
            Author = "Чак Поланік",
            Publisher = csd,
            Year = 2023,
            Styles = new List<Style> { modernForeignprose },
            Photo = "https://book-ye.com.ua/upload/resize_cache/iblock/e3e/520_860_1/73b7820a_80c2_11e6_80c0_000c29ae1566_ea8f93ec_7c8c_11ee_818c_00505684ea69.jpg",
        };

        var book10 = new Book
        {
            Id = 10,
            Name = "Гарлін",
            Author = "Стьєпан Шеїч",
            Publisher = pm,
            Year = 2023,
            Styles = new List<Style> { comics },
            Photo = "https://book-ye.com.ua/upload/iblock/8f1/73ddea3c_701c_11ea_812d_000c29ae1566_1376e0a4_701e_11ea_812d_000c29ae1566.jpg",
        };

        return new List<Book> { book1, book2, book3, book4, book5, book6, book7, book8, book9, book10 };
    }
}
