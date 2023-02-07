using Everydayinik;

bool isListenning = true;

DateTime now = DateTime.Now;

int plusDay = 0;
List<Date1> zametki = new List<Date1>() { };

Console.WriteLine(now.AddDays(plusDay).ToLongDateString());

int posicion = 1;

Date1 zametka1 = new Date1();

zametka1.Name = "Сходить в МПТ";
zametka1.Description = "Cходить и посидеть на всех парах";
zametka1.Done = "08.02.23";
zametka1.Dade = new DateTime(2023, 02, 08).ToLongDateString();
zametki.Add(zametka1);

Date1 zametka2 = new Date1();
zametka2.Name = "Покушать";
zametka2.Description = "Поесть корнишоны";
zametka2.Done = "09.02.23";
zametka2.Dade = new DateTime(2023, 02, 09).ToLongDateString();
zametki.Add(zametka2);

Date1 zametka3 = new Date1();
zametka3.Name = "Отдохнуть";
zametka3.Description = "Я устал";
zametka3.Done = "11.02.23";
zametka3.Dade = new DateTime(2023, 02, 11).ToLongDateString();
zametki.Add(zametka3);

Date1 zametka4 = new Date1();
zametka4.Name = "Сходить в магазин";
zametka4.Description = "Купить хлеб";
zametka4.Done = "15.02.23";
zametka4.Dade = new DateTime(2023, 02, 15).ToLongDateString();
zametki.Add(zametka4);

Date1 zametka5 = new Date1();
zametka5.Name = "Доделатьвсе праки";
zametka5.Description = "Ещё очень много";
zametka5.Done = "07.02.23";
zametka5.Dade = new DateTime(2023, 02, 07).ToLongDateString();
zametki.Add(zametka5);

void zamet(ConsoleKeyInfo key)
{
    if (zametka1.Dade == now.AddDays(plusDay).ToLongDateString())
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("1: " + zametki[0].Name);
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("2: " + zametki[1].Name);
        if (key.Key == ConsoleKey.Enter && posicion == 1)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[0].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[0].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[0].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[0].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
        else if (key.Key == ConsoleKey.Enter && posicion == 2)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[1].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[1].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[1].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[1].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
    }
    else if (zametka3.Dade == now.AddDays(plusDay).ToLongDateString())
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("1: " + zametki[2].Name);
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("2: " + zametki[3].Name);
        if (key.Key == ConsoleKey.Enter && posicion == 1)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[2].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[2].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[2].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[2].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
        else if (key.Key == ConsoleKey.Enter && posicion == 2)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[3].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[3].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[3].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[1].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
    }
    else if (zametka5.Dade == now.AddDays(plusDay).ToLongDateString())
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("1: " + zametki[4].Name);
        if (key.Key == ConsoleKey.Enter && posicion == 1)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[4].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[4].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[4].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[4].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
    }
}


void Cursor(ConsoleKeyInfo key)
{
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (posicion - 1 == 0)
        {
            posicion = 1;
        }
        else
        {
            posicion--;
        }
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        posicion++;
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        isListenning = false;
    }
    Console.Clear();
}

void date2(ConsoleKeyInfo key)
{
    if (key.Key == ConsoleKey.RightArrow)
    {
        plusDay++;
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        plusDay--;
    }
}
while (isListenning == true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Cursor(key);
    date2(key);
    zamet(key);
    Console.SetCursorPosition(0, 0);
    Console.WriteLine(now.AddDays(plusDay).ToLongDateString());
    Console.SetCursorPosition(0, posicion);
    Console.WriteLine("->");
}