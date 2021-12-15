# Snyggare lösning på pagineringen

Hejsan allihopa. Här nu i den senaste commiten så kommer en vettig implementering 
av pagineringen.

Den funkar så att om vi GETtar https://localhost:7012/api/animal så kommer controllern 
defaulta till att ge oss första pagen med fem items.

Vill vi istället ha en annan page så kör vi på https://localhost:7012/api/animal?currentPage=2&itemsPerPage=1

## Förändringar jämför med ful-lösningen

Vi gör nu vår filtrering av datat direkt i repot. Vi hämtar alltså hem max itemsPerPage djur i hämtningen.
Vi måste dock göra en andra slagning för att få ut totalantalet av djur i databasen. Den slagningen 
kommer vi tyvärr inte undan.

Defaultvärden för itemsPerPage och currentPage sätter vi direkt i controllern.
