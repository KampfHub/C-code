double receivedCrystal = 0;
double goldPoint1 = 1;
double goldPoint2 = 50;
double goldPoint3 = 3500;
double goldPoint4 = 85000;
double goldPoint5 = 600000;
double goldPoint6 = 1200000;
double crystalPoint1 = 1;
double crystalPoint2 = 1;
double crystalPoint3 = 20;
double crystalPoint4 = 250;
double crystalPoint5 = 1000;
double crystalPoint6 = 1500;
Console.WriteLine("Enter the quantity of gold");
double currentGold = Convert.ToDouble(Console.ReadLine());

if (currentGold == goldPoint1) receivedCrystal = crystalPoint1;
if (currentGold <= goldPoint2) receivedCrystal = crystalPoint2;
if (currentGold <= goldPoint3 & currentGold > goldPoint2) receivedCrystal = getGold(crystalPoint2,crystalPoint3,goldPoint2, goldPoint3, currentGold);
if (currentGold <= goldPoint4 & currentGold > goldPoint3) receivedCrystal = getGold(crystalPoint3, crystalPoint4, goldPoint3, goldPoint4, currentGold);
if (currentGold <= goldPoint5 & currentGold > goldPoint4) receivedCrystal = getGold(crystalPoint4, crystalPoint5, goldPoint4, goldPoint5, currentGold);
if (currentGold > goldPoint5) receivedCrystal = getGold(crystalPoint5, crystalPoint6, goldPoint5, goldPoint6, currentGold);

Console.WriteLine("Received Crystal = ");
Console.WriteLine(Math.Round(receivedCrystal));

double getGold(double crystalBottom, double crystalTop, double goldBottom, double goldTop, double currentGold)
{
    double summaryGold = (crystalTop - crystalBottom)/(goldTop-goldBottom) * (currentGold - goldBottom) + crystalBottom;
    return summaryGold;
}