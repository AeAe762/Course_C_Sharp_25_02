// http://rebus1.com/index.php?item=tower

 void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
 {
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

// string with = "1" переменная с которой будут перекладываться кружки
// string on = "3" переменная на которую будут перекладываться кружки
// string some = "2" промежуточная переменная
// int count = 3 количество кружков
