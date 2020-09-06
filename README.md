# NASA NEW ROVER API
### för Inlämning: En fulländad webb-applikation, WU19

NASA fick nys om att ni hade byggt några smått fantastiska klientgränsnitt till deras foto-API, och tänkte att eftersom ni hade koden klar kanske ni var intresserade av att hjälpa dem utveckla nästa API? På era vägnar tackade vi såklart ja!

Till våren kommer NASA testa 3 st nya rovers (rymdsonder), som de eventuellt ska skicka upp till Mars. De vill att ni bygger ett nytt REST API som kan skicka information om de nya sonderna och även att ni bygger ut ett klientgränsnitt för att visa detta...


### Krav på ditt API:
* Din API lösning ska vara byggt i ASP.NET Core, version 3.0 eller 3.1.
* Din ASP.NET applikation ska tillhandahålla minst 4 st åtkomstpunkter (endpoints/actions) som går nå via klientanrop
* Dessa åtkomspunkter skall endas använda verbet GET.
* Namnet på den rymdsond (rover) du vill hämta information av skall skickas med i alla anrop som en parameter. Svaret skall då gälla för den specifika rovern.
* Ni skall använda er av objektorienterade principer i uppbyggnad av ert API:et, varje ny rover skall instansieras via en ”Rover”-klass.

### Krav på klientgränsnittet:
* Du kan utgå från ditt egna klientgränsnitt som du byggde på hackathonet, eller en annan grupps gränsnitt. Du kan också bygga ett nytt eget gränsnitt.
* Gränsnittet ska vara utformat på ett användarvänligt sätt för att visa information från NASAS Mars Rover Photos API samt ditt egna, nyutvecklade, REST API i ASP.NET Core.
* Samtliga endpoints (4) i ditt REST API skall anropas minst en gång ifrån klientgränsnittet ni byggde under workshopen,

 

#### Översatt meddelande från NASA till dig som utvecklare:
"Vi tycker det var fantastiska arbeten ni gjort med vårt REST-API. Vi planerar nu att skicka upp 3 nya rovers till Mars och behöver ett API för att hantera informationen kring dem. Då vi inte kan gå ut med informationen kring de nya maskinerna som skall skickas upp till riktigt ännu Mars får ni som utvecklare skapa 3 nya ”test” rovers.

De värden vi vill kunna hämta för en specifik rover ifrån ert nya API följer i listan nedan:

När en specifik rover skall skall skickas upp till Mars, hitta på något datum så länge Antal hjul Hastighet Vikt

Dessa värden skall hämtas genom olika endpoints med verbet GET. För att specificera vilken rover du vill hämta information om behöver dess namn skickas med i alla anrop (ni bestämmer själva namnet och alla värden en rover har).

Regards

NASA, Houston"



