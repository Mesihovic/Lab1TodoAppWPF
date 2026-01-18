#ToDoApp

Detta projekt är en enkel To Do Applikation skriven i C#. 
Applikationen låter användaren lägga till uppgifter, ta bort uppgifter och visa alla uppgifter i en lista. 
Uppgifterna lagras endast i minnet och rensas när programmet avslutas.

All applikationlogik är i klassen ToDoList, som är separerad från användargränssnittet. 
Ett separat testprojekt med xUnit används för att testa att uppgifter kan läggas till och tas bort korrekt, att ogiltiga borttagningar inte kraschar applikationen, samt att listan uppdateras korrekt.

Jag har valt att göra en konsolapplikation eftersom projektet har utvecklats på macOS.
Lösningen uppfyller kraven för funktionalitet, testning och versionshantering.

