# Zadání projektu (Skupina A): Kalkulačka spotřeby a nákladů na palivo

### 1. Cíl projektu

Vytvořte desktopovou aplikaci ve **WPF** (s využitím code-behind a servisní třídy) a příslušné **Unit Testy**. Aplikace slouží k výpočtu dojezdu vozu se spalovacím motorem, spotřeby paliva na trasu a celkových nákladů na cestu.

### 2. Uživatelské rozhraní (WPF UI)

Okno aplikace (`MainWindow.xaml`) bude obsahovat:

* **Vstupní pole (`TextBox`):**

  * Objem nádrže v litrech (např. `50`)

  * Průměrná spotřeba na 100 km v litrech (např. `6.5`)

  * Délka plánované cesty v km (např. `350`)

  * Cena za 1 litr paliva v Kč (např. `38.50`)

* **Tlačítko (`Button`):**

  * Spočítat (provedení výpočtu a vypsání výsledků)

* **Výstupní pole (`TextBlock`):**

  * Maximální dojezd (v km)

  * Spotřebované palivo na cestu (v litrech)

  * Celková cena za cestu (v Kč)

### 3. Vzorečky pro výpočet

1. **Maximální dojezd:**
   

   $$
   \text{Dojezd (km)} = \left(\frac{\text{Objem nádrže (l)}}{\text{Spotřeba na 100 km (l/100km)}}\right) \times 100
   $$

2. **Potřebné palivo na cestu:**
   

   $$
   \text{Palivo (l)} = \left(\frac{\text{Délka cesty (km)}}{100}\right) \times \text{Spotřeba na 100 km (l/100km)}
   $$

3. **Celková cena cesty:**
   

   $$
   \text{Cena (Kč)} = \text{Palivo (l)} \times \text{Cena za 1 litr (Kč)}
   $$

### 4. Rozhraní (Interface) a Servisní třída

Nejprve vytvořte rozhraní `IFuelCalculatorService`:

```csharp
public interface IFuelCalculatorService
{
    double CalculateRange(double tankCapacity, double consumptionPer100Km);
    double CalculateFuelNeeded(double distance, double consumptionPer100Km);
    double CalculateTripCost(double fuelNeeded, double pricePerLiter);
}
```

Následně vytvořte třídu `FuelCalculatorService`, která toto rozhraní implementuje:

```csharp
public class FuelCalculatorService : IFuelCalculatorService
{
    // Implementace metod podle vzorečků
}
```

### 5. Požadavky na Unit Testy

Vytvořte testovací projekt (např. MSTest / xUnit) a otestujte servisní třídu minimálně těmito scénáři:

1. **Test dojezdu:** Vstup: Nádrž = $50\text{ l}$, Spotřeba = $5\text{ l/100km}$ $\rightarrow$ Očekávaný výsledek: $1000\text{ km}$.

2. **Test spotřebovaného paliva:** Vstup: Vzdálenost = $400\text{ km}$, Spotřeba = $6\text{ l/100km}$ $\rightarrow$ Očekávaný výsledek: $24\text{ l}$.

3. **Test ceny cesty:** Vstup: Palivo = $24\text{ l}$, Cena za litr = $40\text{ Kč}$ $\rightarrow$ Očekávaný výsledek: $960\text{ Kč}$.

---

# Zadání projektu (Skupina B): Bankovní kalkulačka spořicího účtu

### 1. Cíl projektu

Vytvořte desktopovou aplikaci ve **WPF** (s využitím code-behind a servisní třídy) a příslušné **Unit Testy**. Aplikace slouží k výpočtu výnosů z jednoduchého spoření: spočítá úrok za rok, čistý zisk po zdanění a celkovou naspořenou částku.

### 2. Uživatelské rozhraní (WPF UI)

Okno aplikace (`MainWindow.xaml`) bude obsahovat:

* **Vstupní pole (`TextBox`):**

  * Vklad / Jistina v Kč (např. `100000`)

  * Roční úroková sazba v % (např. `5`)

  * Doba spoření v letech (např. `3`)

  * Daň z příjmu / z úroku v % (např. `15`)

* **Tlačítko (`Button`):**

  * Spočítat (provedení výpočtu a vypsání výsledků)

* **Výstupní pole (`TextBlock`):**

  * Hrubý úrok celkem (v Kč)

  * Čistý úrok po zdanění (v Kč)

  * Celková konečná částka k výplatě (v Kč)

### 3. Vzorečky pro výpočet

1. **Hrubý úrok celkem:**
   

   $$
   \text{Hrubý úrok (Kč)} = \text{Vklad (Kč)} \times \left(\frac{\text{Úroková sazba (\%)}}{100}\right) \times \text{Doba (roky)}
   $$

2. **Čistý úrok po zdanění:**
   

   $$
   \text{Čistý úrok (Kč)} = \text{Hrubý úrok (Kč)} \times \left(1 - \frac{\text{Daň (\%)}}{100}\right)
   $$

3. **Celková konečná částka:**
   

   $$
   \text{Celková částka (Kč)} = \text{Vklad (Kč)} + \text{Čistý úrok (Kč)}
   $$

### 4. Rozhraní (Interface) a Servisní třída

Nejprve vytvořte rozhraní `ISavingsCalculatorService`:

```csharp
public interface ISavingsCalculatorService
{
    double CalculateGrossInterest(double principal, double interestRate, double years);
    double CalculateNetInterest(double grossInterest, double taxRate);
    double CalculateTotalAmount(double principal, double netInterest);
}
```

Následně vytvořte třídu `SavingsCalculatorService`, která toto rozhraní implementuje:

```csharp
public class SavingsCalculatorService : ISavingsCalculatorService
{
    // Implementace metod podle vzorečků
}
```

### 5. Požadavky na Unit Testy

Vytvořte testovací projekt (např. MSTest / xUnit) a otestujte servisní třídu minimálně těmito scénáři:

1. **Test hrubého úroku:** Vstup: Vklad = $100000\text{ Kč}$, Sazba = $5\%$, Doba = $2\text{ roky}$ $\rightarrow$ Očekávaný výsledek: $10000\text{ Kč}$.

2. **Test čistého úroku:** Vstup: Hrubý úrok = $10000\text{ Kč}$, Daň = $15\%$ $\rightarrow$ Očekávaný výsledek: $8500\text{ Kč}$.

3. **Test celkové částky:** Vstup: Vklad = $100000\text{ Kč}$, Čistý úrok = $8500\text{ Kč}$ $\rightarrow$ Očekávaný výsledek: $108500\text{ Kč}$.