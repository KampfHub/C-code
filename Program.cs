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
double purchasedGold = Convert.ToDouble(Console.ReadLine());

if (purchasedGold == goldPoint1) receivedCrystal = crystalPoint1;
if (purchasedGold <= goldPoint2) receivedCrystal = crystalPoint2;
if (purchasedGold <= goldPoint3 & purchasedGold > goldPoint2) receivedCrystal = getGold(crystalPoint2,crystalPoint3,goldPoint2, goldPoint3, purchasedGold);
if (purchasedGold <= goldPoint4 & purchasedGold > goldPoint3) receivedCrystal = getGold(crystalPoint3, crystalPoint4, goldPoint3, goldPoint4, purchasedGold);
if (purchasedGold <= goldPoint5 & purchasedGold > goldPoint4) receivedCrystal = getGold(crystalPoint4, crystalPoint5, goldPoint4, goldPoint5, purchasedGold);
if (purchasedGold > goldPoint5) receivedCrystal = getGold(crystalPoint5, crystalPoint6, goldPoint5, goldPoint6, purchasedGold);

Console.WriteLine("Received Crystal = ");
Console.WriteLine(Math.Round(receivedCrystal));

double getGold(double crystalBottom, double crystalTop, double goldBottom, double goldTop, double currentGold)
{
    double totalGold = (crystalTop - crystalBottom)/(goldTop-goldBottom) * (currentGold - goldBottom) + crystalBottom;
    return totalGold;
}