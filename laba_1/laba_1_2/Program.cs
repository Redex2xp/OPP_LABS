using laba_1_2;


INowDateTimeFormatter dateE = new EuropeDateTimeFormatter();
Decor decorE = new Decor(dateE);

INowDateTimeFormatter dateA = new UsaDateTimeFormatter();
Decor decorA = new Decor(dateA);
Decor decorAa = new Decor(decorA);

Console.WriteLine(decorE.FormataDateTime());
Console.WriteLine(decorAa.FormataDateTime());

Console.WriteLine(decorA.FormataDateTime());