﻿
double peterBudjed = double.Parse(Console.ReadLine());
int videoCard = int.Parse(Console.ReadLine());
int procesor = int.Parse(Console.ReadLine());
int ramPamet = int.Parse(Console.ReadLine());

//Петър иска да купи N видеокарти, M процесора и P на брой рам памет.
//Ако броя на видеокартите е по-голям от този на процесорите получава 15%
//отстъпка от крайната сметка. Важат следните цени:
//· Видеокарта – 250 лв./бр.
//· Процесор – 35% от цената на закупените видеокарти/бр.
//· Рам памет – 10% от цената на закупените видеокарти/бр.
////Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне

double priceCard = videoCard * 250;
double priceProcesor = priceCard * 0.35;
double procesorPrice =