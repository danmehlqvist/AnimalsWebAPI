# Snyggare l�sning p� pagineringen

Hejsan allihopa. H�r nu i den senaste commiten s� kommer en vettig implementering 
av pagineringen.

Den funkar s� att om vi GETtar https://localhost:7012/api/animal s� kommer controllern 
defaulta till att ge oss f�rsta pagen med fem items.

Vill vi ist�llet ha en annan page s� k�r vi p� https://localhost:7012/api/animal?currentPage=2&itemsPerPage=1

## F�r�ndringar j�mf�r med ful-l�sningen

Vi g�r nu v�r filtrering av datat direkt i repot. Vi h�mtar allts� hem max itemsPerPage djur i h�mtningen.
Vi m�ste dock g�ra en andra slagning f�r att f� ut totalantalet av djur i databasen. Den slagningen 
kommer vi tyv�rr inte undan.

Defaultv�rden f�r itemsPerPage och currentPage s�tter vi direkt i controllern.
