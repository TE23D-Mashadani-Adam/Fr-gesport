﻿using System.Diagnostics;

Console.WriteLine("Väkommen till frågesport, du kommer att få svara på tre frågor, försök svara rätt på så "+
"många som du kan, lycka till!");

int poäng = 0;

String ans1 = "";
String ans2 = "";
String ans3 = "";

bool wrongFormat;


//Frågor

while(true){
Console.WriteLine("Vilken är den bästa fotbollspelaren i historien? a) Ronaldo b) Messi c) Bellingham");
ans1 = Console.ReadLine();
if(ans1 == "b" || ans1 == "a" || ans1 == "c"){
    if(ans1=="a"){
    poäng += 1;
    }
    break;
}
}


while(true){
Console.WriteLine("Vem vann VM 2022? a)Franktike b) Argentina c) Spanien");
ans2 = Console.ReadLine();
if(ans2 == "b" || ans2 == "a" || ans2 == "c"){
    if(ans2=="b"){
    poäng += 1;
}
    break;
}
}

while(true){
Console.WriteLine("Vad är antalet spelare i varje lag i en fotbollsmatch? a) 10 b) 11 c) 12");
ans3 = Console.ReadLine();
if(ans3 == "b" || ans3 == "a" || ans3 == "c"){
    if(ans3=="b"){
    poäng += 1;
    break;
}
}
}

Console.WriteLine("\n");

switch(poäng){
    case 1: Console.WriteLine($"Antal poäng: {poäng}, Vad dåligt du är, du fick bara en poäng!!");
    break;
    case 2: Console.WriteLine($"Antal poäng: {poäng}, Bra jobbat!");
    break;
    case 3: Console.WriteLine($"Antal poäng: {poäng}, Fantastiskt bra jobbat! Du fick alla rätt!");
    break;
}

Console.ReadLine();





