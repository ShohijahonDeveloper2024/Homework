using System;

class Programm
{
  static void Main()
  {
    Console.Write("Aqli robotdan foydanaish uchun unga buyruq bering: ");
    string buyruq = Console.ReadLine();
    string amal = "";
    switch (buyruq.ToLower())
    {
      case "sakrash":
        amal = "Aqli robot sakrayapti....";
        break;
      case "yugursh":
        amal = "Aqli robot yuguryapti...";
        break;
      case "gapirish":
        amal = "Aqli robot siz bilan suhbatlashyapti...";
        break;
      case "uqish":
        amal = "Aqli robot kitob o'qiyapti...";
        break;
      case "yordam":
        amal = "Aqli robot sizga yordamlashyapti..";
        break;
      case "yozish":
        amal = "Aqli robot sizning uyga vazifalaringizni bajarayapti..";
        amal = "U English tilidan \"ESSAY\" yozyapti...";
        break;
      default:
        amal = $"Kechirasiz!, Siz noma'lum buyruq kiritdingiz! \n Boshqa buyruq kiriting! ";
        break;
    }
    Console.WriteLine(amal);

    string order = buyruq.ToLower() switch
    {
      "sakrash" => "Aqli robot sakrashga tayor!",
      "yozish" => "Aqli robot yozishga tayor!",
      "yugurish" => "Aqli robot yugurishga tayor!",
      "gapirish" => "Aqli robot gapirishga tayor!",
      "yordam" => "Aqli robot yordamlashishga tayor!",
      "uqish" => "Aqli robot kitob o'qishga tayor!",
      _ => "Kechirasiz!, Siz xato buyruq kiritdingiz, boshqa buyruq kiritng!"
    };
    Console.WriteLine(order);

    // task 2
    Console.WriteLine("Salom yangi foydalanuvchi \"Online dukon\"imizga xush kelibsiz! ");
    Console.Write("Maxsulot nomini kiriting: ");
    string mahsulotNomi = Console.ReadLine();
    mahsulotNomi = mahsulotNomi.ToLower();
    string narh = "";
    if (mahsulotNomi == "olma" || mahsulotNomi == "uzum" || mahsulotNomi == "anor")
    {
      narh = "5000";
    }
    else if (mahsulotNomi == "non" || mahsulotNomi == "pista" || mahsulotNomi == "tuxum")
    {
      narh = "2000";
    }
    else if (mahsulotNomi == "baliq" || mahsulotNomi == "grill" || mahsulotNomi == "steak")
    {
      narh = "50000";
    }
    else if (mahsulotNomi == "bodom" || mahsulotNomi == "yongoq")
    {
      narh = "25000";
    }

    string tekshirish =
        narh != ""
          ? $"\"{mahsulotNomi.ToUpper()}\" mahsulotining  narhi: {narh} so'm."
          : $"Kecirasiz \"{mahsulotNomi.ToUpper()}\" mahsuloti  bizning dukonimizda mavjud emas!";

    Console.WriteLine(tekshirish);

    // task 3

    Console.Write("Rang kiriting: ");
    string rang1 = Console.ReadLine().ToLower();

    string natija1 =
        rang1 == "qizil" ? "To'xtang!" :
        rang1 == "sariq" ? "Tayyorlaning!" :
        rang1 == "yashil" ? "Yuring!" :
        "Noma'lum rang!";

    Console.WriteLine(natija1);

    Console.Write("\nRang kiriting: ");
    string rang2 = Console.ReadLine().ToLower();

    // 🔥 ternary + &&
    string natija2 =
        (rang1 == "yashil" && rang2 == "yashil") ? "Tez yurmayman!" :
        rang2 == "qizil" ? "To'xtang!" :
        rang2 == "sariq" ? "Tayyorlaning!" :
        rang2 == "yashil" ? "Yuring!" :
        "Noma'lum rang!";

    Console.WriteLine(natija2);
  }
}


