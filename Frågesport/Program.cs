﻿using System.Diagnostics;

Console.WriteLine("Väkommen till frågesport, du kommer att få svara på tre frågor, försök svara rätt på så "+
"många som du kan, lycka till!");

int poäng = 0;

//Frågor
Console.WriteLine("Vilken är den bästa fotbollspelaren i historien? a) Ronaldo b) Messi c) Bellingham");
String ans1 = Console.ReadLine();
if(ans1=="a"){
    poäng += 1;
}
Console.WriteLine("Vem vann VM 2022? a)Franktike b) Argentina c) Spanien");
String ans2 = Console.ReadLine();
if(ans2=="b"){
    poäng += 1;
}
Console.WriteLine("Vad är antalet spelare i varje lag i en fotbollsmatch? a) 10 b) 11 c) 12");
String ans3 = Console.ReadLine();
if(ans3=="b"){
    poäng += 1;
}





