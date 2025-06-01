# Rezerwix
Projekt "Rezerwix" to aplikacja desktopowa stworzona w technologii .NET Windows Forms, służąca do zarządzania i rezerwacji biletów na różnego rodzaju wydarzenia. System jest zaprojektowany z myślą o dwóch typach użytkowników: zwykłych użytkownikach oraz administratorach, z których każdy ma dostęp do dedykowanych funkcjonalności.

# Opis bazy danych (ERD)
![image](https://github.com/user-attachments/assets/254e37b3-bc14-46d5-a54f-ca9f9b6473ae)

# Funkcjonalności
Aplikacja zawiera dedykowane funkcjonalności w zależności od roli którą posiada użytkownik aplikacji

**Funkcjonalności ogólne**
- Możliwość założenia konta (wymagane pola to nazwa użytkownika, imie, nazwisko, hasło, email oraz data urodzenia)
- System logowania
  
**Użytkownik**
- Po zalogowaniu do aplikacji użytkownik ma możliwość przeglądania wszystkich dostępnych nadchodzących wydarzeń, następnie po wejściu na szczegóły danego wydarzenia może zarezerwować bilet/ty. Zakładka ta
  ma również system filtracji po kategorii oraz wyszukiwarkę przez co użytkownik może w prostszy sposób znaleźć interesujący go rekord
- Użytkownik może również przeglądać swoje rezerwacje w zakładce *Moje bilety*, gdzie w razie potrzeby może również je anulować.
- Kolejną funkcjonalnością którą ma użytkownik to sprawdzenie swoich danych oraz możliwość ich edycji (np. Email lub hasło)

**Administrator**
- Po zalogowaniu administrator ma swój dedykowany widok z zakładkami takimi jak *Użytkownicy* oraz *Zarządzanie wydarzeniami*
- W zakładce *Użytkownicy*, administrator ma możliwość usunięcia konta danego użytkownika oraz ma możliwość mianowania nowego użytkownika administratorem (zmiana jego roli)
- W załadce *Zarządzanie wydarzeniami* administrator ma możliwość dodania nowego wydarzenia, ma również możliwość edytowania wybranego oraz może je w razie potrzeby usunąć

# Użyte technologie
- Winforms C# (.NET 9.0)
- Postgres 14.0
- Docker

# Pierwsza konfiguracja
1. W pierwszym kroku należy pobrać zainstalować i uruchomić aplikację Docker
2. Następnie należy sklonować repozytorium
3. W kolejnym kroku, uruchomić projekt w dowolnym edytorze (np. Visual Studio)
4. W terminalu należy wpisać komendę:
   ```
   docker-compose up --build
   ```
5. Po uruchomieniu się aplikacji w dockerze, należy zastosować migracje. Należy uruchomić terminal zarządzania pakietami NuGet i wpisać komendę:
   ```
   Update-Database
   ```
6. Następnie można uruchomić już aplikację z poziomu edytora

# Instrukcja obsługi
## Logowanie
1. Podajemy wymagane dane w formularzu
  ![image](https://github.com/user-attachments/assets/d5ec7cc3-e885-4c80-983a-856a2ea64109)
2. W przypadku poprawnych danych aplikacja przenosi do widoku głównego
  ![image](https://github.com/user-attachments/assets/ee1e2d6a-3d2d-4a61-91d7-e3c600c8e364)
- W przypadku podania złych danych wyskakuje błąd
  ![image](https://github.com/user-attachments/assets/5cc6c985-b70d-4ab5-99de-d6459e6e954b)

## Rejestracja
1. Należy podać wymagane pola
  ![image](https://github.com/user-attachments/assets/152eb223-620b-47e2-829c-f4670db42523)
3. Następnie kliknąć *Rejestracja*
4. Następnie po rejestracji zalogować się wypełniając wymagane pola

*Przypadki brzegowe rejestracji*
![image](https://github.com/user-attachments/assets/6562f0a9-ebcf-4e21-ab4b-47fe496665b2)

   
## Rezerwacja biletu
1. Po zalogowaniu aplikacja jest już na widoku wszystkich wydarzeń
2. Następnie należy kliknąc przycisk *Szczegóły*
  ![image](https://github.com/user-attachments/assets/76213a63-3829-4138-a765-f18ee2b03726)
3. Następnie należy wybrać ilość biletów i należy kliknąć *Zarezerwuj bilety*
  ![image](https://github.com/user-attachments/assets/d705349b-4685-4183-a607-e6d146fb5a78)
**Przypadki brzegowe**
- Przypadek kiedy wydarzenie nie ma już wystarczającej ilości miejsc przyciski zostają wyłączone
  ![image](https://github.com/user-attachments/assets/f7d98fcc-24bc-4ea8-a095-377b53ef7bd2)
- Przypadek kiedy wydarzenie już się rozpoczęło/zakończyło
  ![image](https://github.com/user-attachments/assets/7839e0f1-7f24-4654-a3f1-6f78be826ed3)

## Przeglądanie biletów
1. Po zalogowaniu należy wejść w zakładkę *Moje bilety*
2. W tej zakładce można przeglądać bilety i ewentualnie je usunać
   ![image](https://github.com/user-attachments/assets/89bb28e6-0ab9-4188-ae48-36fa25a3c208)
3. Usunięcie biletu po kliknięciu przycisku *Anuluj*
   ![image](https://github.com/user-attachments/assets/9f929150-f82b-41f8-88b4-f042a95da925)
   ![image](https://github.com/user-attachments/assets/27c80076-21ff-42ca-808e-cce77499b90a)

## Edycja danych
1. Po zalogowaniu należy wejść w zakładkę *Mój profil*
2. Następnie należy wypełnić pola i nacisnąć *Zapisz zmiany* lub w przypadku zmiany hasła *Zmień hasło*, dane zostaną zaktualizowane
   ![image](https://github.com/user-attachments/assets/5c7bef3a-f508-4f8b-8915-f24e2a0f2055)

**Przypadki brzegowe edycji danych**
![image](https://github.com/user-attachments/assets/3cf4ac41-8bde-4193-ba49-93a579ec3e54)

**Tutaj do każdego pola jest analogicznie podobny błąd**
![image](https://github.com/user-attachments/assets/d0614ff5-89b3-4186-90c8-e4a8893fd880)


![image](https://github.com/user-attachments/assets/b6ad38d6-ae0d-42e2-99f1-2b7e4b2b147b)
![image](https://github.com/user-attachments/assets/9893bef3-6db7-431f-9489-0c0f6e8f4432)
![image](https://github.com/user-attachments/assets/112b6e81-2565-42fe-909b-8bddba7a6fa2)
![image](https://github.com/user-attachments/assets/5ecbcaa7-a865-47b1-abb5-3ce50ab58012)

## Dodanie/edycja/usunięcie nowego wydarzenia przez administratora
**Dodanie**
1. Należy zalogować się na konto administratora podając jego dane
2. Po zalogowaniu się, kliknąć przycisk *Zarządzaj wydarzeniami*
  ![image](https://github.com/user-attachments/assets/96ae24ff-9dde-4c2c-b967-42b4cfa8d6c8)
3. Następnie kliknąć przycisk *Dodaj nowe wydarzenie*
   ![image](https://github.com/user-attachments/assets/2d68b41a-fcf7-4b12-8d0e-8f82f83cc5d3)
4. W kolejnym kroku trzeba wypełnić wszystkie pola oznaczone * i kliknąć *Zapisz*

**Edycja**
*Edycja wydarzenia wygląda bardzo podobnie więc nie zostaje tutaj opisana*

**Usuwanie**
1. Znajdując się w zakładce zarządzaj wydarzeniami, należy zaznaczyć intresujący rekord
2. W kolejnym kroku nacisnąć przycisk *Usuń zaznaczone*
3. Rekord zostanie usunięty
   ![image](https://github.com/user-attachments/assets/ee6f7f3d-ed4f-444f-ad44-718b9330b14a)
   ![image](https://github.com/user-attachments/assets/023a446c-b2e3-483a-be8b-f7d54418fd9c)

**Przypadki brzegowe dodawania wydarzenia**
![image](https://github.com/user-attachments/assets/531c3049-524b-49e2-a489-96039b2e0d0e)

## Zmiana roli użytkownika
1. Po zalogowaniu się na konto administratora, należy wejść w zakładkę *Użytkownicy*
2. Następnie należy zaznaczyć interesujący rekord i nacisnąć przycisk *Zmień rolę*
3. Teraz należy wybrać rolę i zatwierdzić
![image](https://github.com/user-attachments/assets/596d138a-1104-4fe2-b57d-be5b18f630a3)

## Usunięcie użytkownika
1. Bedąc zalogowanym na koncie użytkownika, oraz w zakładce *Użytkownicy* należy zaznaczyć interesujący nas rekord
2. Następnie należy kliknąć *Usuń użytkownika* oraz zatwierdzić
![image](https://github.com/user-attachments/assets/a7ea1381-1eb1-4567-89af-5d41cde3afa2)
![image](https://github.com/user-attachments/assets/491c40f2-4c6c-434e-9b86-78f40424aab8)







   




  


  

