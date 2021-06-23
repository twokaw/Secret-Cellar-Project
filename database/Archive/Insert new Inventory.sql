 SELECT * FROM  supplier s
 RIGHT JOIN (
SELECT DISTINCT supplierId FROM 
(

SELECT 'WINE' Class, '853706002034' itemid, 'Butter Chardonnay' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000001' itemid, 'Orin Swift Fragile' ItemDescription, 15.0 supplyPrice, 15.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '747846010144' itemid, 'Hakutsuru Sake' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '766238809777' itemid, 'Alvear' ItemDescription, 29.75 supplyPrice, 29.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '084692000234' itemid, 'Croft Port 2009' ItemDescription, 29.99 supplyPrice, 29.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '087202008058' itemid, 'Porto Tellu''s Ruby' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083420151699' itemid, 'Gibson pale Dry Sherry' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000002' itemid, 'Orin Swift Machete' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094799010401' itemid, 'W&J Graham''s Porto' ItemDescription, 22.99 supplyPrice, 22.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086003780248' itemid, 'Robert Mondavi Chardonney' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000003' itemid, 'Nouveau-Nez Vigneron' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3760031472913' itemid, 'Bastide Miraflores Syrah & Genache' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '736040532385' itemid, 'Passiomento' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '657891716147' itemid, 'Treana Paso Robles Cabernet 2016' ItemDescription, 20.0 supplyPrice, 27.99 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '850432006022' itemid, 'Hell Hound Red blend' ItemDescription, 23.0 supplyPrice, 23.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '857680001021' itemid, 'Shannon Ridge Petite Sirah' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '856442005536' itemid, 'Plungerhead Petite Sirah' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '652935100098' itemid, '6th Sense Syrah' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '826498081600' itemid, 'Balletto Syrah' ItemDescription, 29.99 supplyPrice, 29.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '760999989037' itemid, 'Ball Buster, The' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000004' itemid, 'Brady Petite Sirah' ItemDescription, 23.99 supplyPrice, 23.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '603012005065' itemid, 'Chronic Cellars, Suite Petite' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '769434103267' itemid, 'Le Cigare Volant' ItemDescription, 35.75 supplyPrice, 35.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '9322246002008' itemid, 'Wallace Shiraz' ItemDescription, 27.99 supplyPrice, 27.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8033413001090' itemid, 'Barone di Valforte Montepulciano' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '798304041934' itemid, 'Scout''s Honor' ItemDescription, 38.99 supplyPrice, 38.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '767749002275' itemid, 'Stump Jump GSM' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '853124003231' itemid, 'Hollen Family Cabernet' ItemDescription, 11.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '189113000616' itemid, 'Cachette' ItemDescription, 6.0 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '852282002803' itemid, 'GEN5' ItemDescription, 9.0 supplyPrice, 12.99 Price, 'NONE' supplierId UNION 
SELECT 'WINE' Class, '082896780402' itemid, 'Bonterra Cabernet Sauvignon' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '077190000516' itemid, 'Snoqualmie Cabernet Sauvignon' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '833302005387' itemid, 'Big Smooth Cabernet Sauvignon' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '891540001462' itemid, 'Caricature Cabernet Sauvignon' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'GLOBAL WINES' supplierId UNION 
SELECT 'WINE' Class, '088232002610' itemid, 'Sebastiani Cabernet Sauvignon' ItemDescription, 13.5 supplyPrice, 18.99 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'WINE' Class, '10000005' itemid, 'Josh Cabernet Sauvignon' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '814617009307' itemid, 'Luna Cabernet Sauvignon' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '768035203000' itemid, 'Silver Palm Cabernet Sauvignon' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586007859' itemid, 'Intrinsic Cabernet Sauvignon' ItemDescription, 22.0 supplyPrice, 22.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000006' itemid, 'Smith & Hook Cabernet Sauvignon' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '733952997103' itemid, 'Justin Cabernet Sauvignon' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000007' itemid, 'Silencieux Cabernet Sauvignon' ItemDescription, 56.99 supplyPrice, 56.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000008' itemid, 'Treana Cabernet Sauvignon' ItemDescription, 27.99 supplyPrice, 27.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '652935100067' itemid, 'Earthquake Cabernet Sauvignon' ItemDescription, 19.5 supplyPrice, 29.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '891518001708' itemid, 'Fabre Montmayor Grand Vin' ItemDescription, 54.99 supplyPrice, 54.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083417023206' itemid, 'Geyser Peak Cabernet Sauvignon Reserve' ItemDescription, 39.99 supplyPrice, 39.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '815132010083' itemid, 'Masi Brolo Campfiorin' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '689076851343' itemid, 'Manzanita Creek Zinfandel' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '896599002002' itemid, 'Layer Cake Primitivo' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083837006308' itemid, 'Castle Rock Zinfandel' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '814617007037' itemid, 'Asylum Zin' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086003258006' itemid, 'Saldo' ItemDescription, 30.99 supplyPrice, 30.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '681416803005' itemid, 'Zinzilla' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '839146005903' itemid, 'Cigar Zinfandel' ItemDescription, 16.5 supplyPrice, 16.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '833302005363' itemid, 'Big Smooth Zinfandel' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '652935100012' itemid, 'Seven deadly sins Zinfandel' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '7809558500245' itemid, 'Casa Rivas carmenerr' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000009' itemid, 'Brassfields Cabernet Sauvignon' ItemDescription, 89.99 supplyPrice, 89.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '896599002033' itemid, 'Layer Cake Malbec' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082734344049' itemid, 'Trivento Golden Reserve Malbec' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '852282002162' itemid, 'Zolo Malbec' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '813942010552' itemid, 'Finca El Origen' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '717888790120' itemid, '1895 Coleccion Malbec' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082734341246' itemid, 'Trivento Malbec Reserve' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '891518001722' itemid, 'Fabre Montmayou' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089832845706' itemid, 'Santa Julia Reserva Malbec' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '852282002179' itemid, 'Zolo Merlot' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586003431' itemid, 'H3 Merlot' ItemDescription, 15.5 supplyPrice, 15.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082896077793' itemid, 'Bonterra Merlot' ItemDescription, 16.75 supplyPrice, 16.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '768035203079' itemid, 'Silver Palm Merlot' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586001109' itemid, 'Two Vines Merot' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088232002634' itemid, 'Sabastini Merlot' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '814617003008' itemid, 'Luna Merlot' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '814617002001' itemid, 'Luna Sangiovese' ItemDescription, 20.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '813495010771' itemid, 'Zorzal Gran Terroir Pinot Noir' ItemDescription, 22.99 supplyPrice, 22.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '606508024175' itemid, 'Gancia Brachetto D''Acqui' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785470801' itemid, '120 Reserva Especial Pinot Noir' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086788888023' itemid, 'Hahn Pinot Noir' ItemDescription, 11.0 supplyPrice, 14.99 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '852024001828' itemid, 'Richard Grant Pinot Noir' ItemDescription, 42.0 supplyPrice, 42.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '717071911714' itemid, 'Willamette Valley Whole Cluster Pinot Noir' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '815992010025' itemid, 'EQ Pinot Noir' ItemDescription, 41.99 supplyPrice, 41.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '4930709' itemid, 'La Crema Pinot Noir' ItemDescription, 22.99 supplyPrice, 22.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '850440002849' itemid, 'Sola Pinot Noir' ItemDescription, 15.5 supplyPrice, 15.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '696859158995' itemid, 'Thomas George Pinot Noir' ItemDescription, 37.99 supplyPrice, 37.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8008366221789' itemid, 'Stefano Farina Moscato d''Asti' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8010471000586' itemid, 'Alasia' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '084279977638' itemid, 'Risata Moscato d''Asti' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '013022000392' itemid, 'Flore de Moscato' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '080516055640' itemid, 'Move do Moscato' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '855380003017' itemid, 'Bricco Riella Moscato D''Atsi' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '087872630139' itemid, 'Stella Rossa Rosso' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'OKOBOJI WINES' supplierId UNION 
SELECT 'WINE' Class, '819046010122' itemid, 'Mosketto' ItemDescription, 12.5 supplyPrice, 12.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '607054492319' itemid, 'Sweet Bitch Moscato Rose Bubbly' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '038075205303' itemid, 'Raspberry Sparklentini' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '038075202302' itemid, 'Verdi Spumante' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083417006612' itemid, 'Da Luca Prosecco' ItemDescription, 11.78429 supplyPrice, 14.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '701253002000' itemid, 'Gruet Brut' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '701253006008' itemid, 'Gruet Brut Rose' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '097546102008' itemid, 'Roederer Estate Brut' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '011699008741' itemid, 'Beaujolais Nouveau' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586003899' itemid, 'Nicolas Feuillatte Brut Reserve' ItemDescription, 39.99 supplyPrice, 39.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000010' itemid, 'Kirkwood My First Crush' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000011' itemid, 'Kirkwood Blue Bell Sparkling Wine' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '892339002172' itemid, 'Save italia' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '745163231006' itemid, 'Amarone Della Valpolicella' ItemDescription, 39.99 supplyPrice, 39.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785130071' itemid, 'Giulio Straccali' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '098709252004' itemid, 'Ciro Rosso Classico' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '098709252158' itemid, 'Librandi Ciro Bianco 2018' ItemDescription, 8.0 supplyPrice, 12.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '084692441341' itemid, 'Michele Chiarlo' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000012' itemid, 'Modus Toscana' ItemDescription, 24.99 supplyPrice, 24.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '851645004096' itemid, 'Locations Italy' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082734192343' itemid, 'Villa Cerna Chianti Riserva' ItemDescription, 40.0 supplyPrice, 40.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '020106501171' itemid, 'Don Ramon' ItemDescription, 7.0 supplyPrice, 11.99 Price, 'CASK & CORK' supplierId UNION 
SELECT 'WINE' Class, '8437012538016' itemid, 'Garnacha de Fuego' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8437005373099' itemid, 'Pruno' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '853891002154' itemid, 'Tarima Hill' ItemDescription, 15.75 supplyPrice, 15.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '853891002161' itemid, 'Tarima Monastrell' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8437010272318' itemid, 'Romanico Tempranillo' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '763159120035' itemid, 'Borsao Garnacha' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '678801000040' itemid, 'Finca Luzon' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '031259045283' itemid, 'Calling Chardonnay' ItemDescription, 31.99 supplyPrice, 31.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '097921970109' itemid, 'Rombauer Chardonnay' ItemDescription, 38.99 supplyPrice, 38.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '016236001032' itemid, 'Chulk Hill Chardonnay' ItemDescription, 38.99 supplyPrice, 38.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '9421901925062' itemid, 'Greywacke Chardonnay' ItemDescription, 30.99 supplyPrice, 30.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000013' itemid, 'Butternut Chardonnay' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '085000016473' itemid, 'Bridlewood Chardonnay' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082896780419' itemid, 'Bonterra Chardonnay' ItemDescription, 9.75 supplyPrice, 14.99 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '026861100109' itemid, 'Ardeche Chardonnay' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586005671' itemid, 'Columbia Crest Chardonnay' ItemDescription, 13.75 supplyPrice, 13.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089208400089' itemid, 'Yalumba viognier' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '810845004008' itemid, 'Van Ruiten Pinot Grigio' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '087241881063' itemid, 'Mezzacorona Pinot Grigio' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '768675960127' itemid, 'King Estate Pinot Gris' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '717071919703' itemid, 'Willamette Valley Pinot Gris' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '721354890023' itemid, 'L''Ecole Chenin Blanc' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '742651123102' itemid, 'Ferrari Carano Fume Blanc' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3850112163219' itemid, 'Gracevina Dry White' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785192185' itemid, 'Paul Mas Picpoul Du Pinet' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785170008' itemid, 'Peter Yealands Sauvignon Blanc' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '894591002525' itemid, 'Long Meadow Ranch' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '017224750123' itemid, 'Caymus Conundrum' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '815992010070' itemid, 'EQ Sauvignon Blanc' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '689352009611' itemid, 'Kim Crawford Sauvignon Blanc' ItemDescription, 16.8 supplyPrice, 23.99 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'WINE' Class, '796238020018' itemid, 'The Other White Blend' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '818013010448' itemid, 'Smashberry white blend' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '730429851104' itemid, 'Zocker gruner Veltliner' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089419151039' itemid, 'Man Vintners Chenin Blanc' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '739949010404' itemid, 'Gazella Vinho Verde' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '184745000041' itemid, 'Kungfu Girl Riesling' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '183103000013' itemid, 'Dr. Losen Reisling' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '607054120090' itemid, 'Fritz de Katz Reisling' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899911000465' itemid, 'New age white' ItemDescription, 12.75 supplyPrice, 12.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899911000304' itemid, 'New Age Red' ItemDescription, 12.75 supplyPrice, 12.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '784255600092' itemid, 'Moselland Arsvitis Riesling' ItemDescription, 15.75 supplyPrice, 15.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '718038555743' itemid, 'Fess Parker Riesling' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '784255600085' itemid, 'Cat Bottle Reisling' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '767749002602' itemid, 'Stump Jump Riesling' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586621840' itemid, 'Chateau ste Michelle' ItemDescription, 12.5 supplyPrice, 12.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086891081564' itemid, 'Grace lane Riesling' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000014' itemid, 'Washington Hills Riesling' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '750625653012' itemid, 'Clean Slate' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785350530' itemid, 'Jean-Luc Colombo Rose' ItemDescription, 8.0 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088790217495' itemid, 'Stone Hill Concord' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899552001173' itemid, 'Pacific rim' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '663194000951' itemid, 'Beach House rose' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3760078860018' itemid, 'Famaey Malbec' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785246819' itemid, 'Artesis Cote du Rhone' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '89294451' itemid, 'Les Trois Couronnes cote du Rhone 2014' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3483812150106' itemid, 'Saint Cosme' ItemDescription, 16.75 supplyPrice, 16.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '084692458745' itemid, 'Louis Jadot Pinot Noir' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '709793000111' itemid, 'Lassegue Saint Emilion Grand Cru' ItemDescription, 79.99 supplyPrice, 79.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '747736472458' itemid, 'Petit chapeau Bordeaux' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '852187012808' itemid, 'Chateau Godeau Saint-Emilion Grand cru' ItemDescription, 34.99 supplyPrice, 34.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3760158260028' itemid, 'Domaine LA Barroche chateauneuf-du-pape' ItemDescription, 56.99 supplyPrice, 56.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '892696001719' itemid, 'Jardin en fleurs vouvray' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000015' itemid, 'Gerard Bertrand' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '761503442444' itemid, 'Reuilly "Les Pierre''s Plates"' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000016' itemid, 'Nautica Notre Dame du Quatourze' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '850189004005' itemid, 'Domaine De Couron Cote du Rhone' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '896016001588' itemid, 'Savigny les Beaune Chardonnay' ItemDescription, 23.0 supplyPrice, 23.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3485851511115' itemid, 'Beaucharme Chardonnay' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086785246871' itemid, 'Artesis Cote du Rhone 2016' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '857488005023' itemid, 'Elicio Grenache & Syrah' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '892903002201' itemid, 'Les Trois Couronnes Cote du Rhone 2017' ItemDescription, 12.5 supplyPrice, 12.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '830949000126' itemid, 'Robert Hall rose de Robles' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089419235111' itemid, 'Miraval Cote de Provence' ItemDescription, 26.6 supplyPrice, 37.6 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '5600228155107' itemid, 'Meet & Meat' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '5600312192049' itemid, 'Paxis red blend' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '603012005089' itemid, 'Chronic Cellars purple Paradise' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '085817310139' itemid, 'Arbor crest Cliff house commemorative edition' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '746751687137' itemid, 'Marietta Old Vine Red' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '720815150225' itemid, 'India Ink Red Blend' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '714119800009' itemid, 'Hell Cat Maggie' ItemDescription, 20.17 supplyPrice, 28.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'WINE' Class, '10000017' itemid, 'Orin Swift Shatter' ItemDescription, 23.99 supplyPrice, 23.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '896599002149' itemid, 'If you see Kay Red Blen' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '657891702423' itemid, 'Troublemaker Red Blend' ItemDescription, 10.0 supplyPrice, 15.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '5600392560851' itemid, 'Vinha do Putto' ItemDescription, 10.0 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '609465862835' itemid, 'Are de Medeiros' ItemDescription, 9.0 supplyPrice, 13.99 Price, 'DIMITRI WINES' supplierId UNION 
SELECT 'WINE' Class, '5604575110024' itemid, 'Cabriz Red Blend' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '698843003052' itemid, 'Mural Red Blend' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '684586204085' itemid, 'Rare Red Blend' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '851573001136' itemid, 'Cristo Syrah' ItemDescription, 22.99 supplyPrice, 22.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088586007194' itemid, 'Motto Red Blend' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '818013010257' itemid, 'Smashberry Red Blend' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '895250001323' itemid, 'Rhuby Dooby' ItemDescription, 13.25 supplyPrice, 13.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000018' itemid, 'Ringneck Red' ItemDescription, 13.25 supplyPrice, 13.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '640626904230' itemid, 'Buchanan House Red Field Blend' ItemDescription, 7.0 supplyPrice, 9.99 Price, 'NONE' supplierId UNION 
SELECT 'WINE' Class, '640626904209' itemid, 'Buchanan House Lazy Afternoon' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899054001466' itemid, 'Tassel Ridge Star Spangled White' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899054001046' itemid, 'Tassel Ridge Red, White, & Blue' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '027551180463' itemid, 'Pink Pirate blush' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '859824001447' itemid, 'Cedar Ridge Atlas' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '859824001041' itemid, 'Cedar Ridge Harvest Blush' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083085430016' itemid, 'Rosatello Rose' ItemDescription, 14.5 supplyPrice, 14.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000019' itemid, 'Kirkwood Masters Cuvee' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '182976000151' itemid, 'Tabor Hone Cheery cherry' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088582000519' itemid, 'St James Cherry' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088582000502' itemid, 'St James Peach' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088582000526' itemid, 'St James Strawberry' ItemDescription, 11.5 supplyPrice, 11.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094922482211' itemid, 'Another place in Time' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000020' itemid, 'Winneshiek Wildberry Winnery Hunga Dunga Bird' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '890455002229' itemid, 'Winneshiek Sunrise Seyval Blanc' ItemDescription, 9.0 supplyPrice, 11.99 Price, 'NONE' supplierId UNION 
SELECT 'WINE' Class, '899054001725' itemid, 'Tassel Ridge In the Dark' ItemDescription, 18.5 supplyPrice, 18.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '640626903905' itemid, 'Buchanan House white' ItemDescription, 14.75 supplyPrice, 14.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094922482150' itemid, 'El Caribe white' ItemDescription, 14.75 supplyPrice, 14.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '897075001182' itemid, 'Snus Hill spinna' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089419015942' itemid, 'Famille Perrin Cote du Rhone' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '605330000135' itemid, 'Red cat' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094922036292' itemid, 'Fireside Frontenac Gris' ItemDescription, 14.5 supplyPrice, 14.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094922893017' itemid, 'Fireside Blu' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '663997000257' itemid, 'Zoe Greek Dry' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'DIMITRI WINES' supplierId UNION 
SELECT 'WINE' Class, '094922482303' itemid, 'Van Wijk Crimson swirl' ItemDescription, 15.75 supplyPrice, 15.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '640626903929' itemid, 'Buchanan House Marquette Reserve' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '858150004207' itemid, 'Wooden wheel leathers' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '080600400028' itemid, 'Chaucer''s Mead' ItemDescription, 15.75 supplyPrice, 15.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '085725108149' itemid, 'Framboise Lambic' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '707596001021' itemid, 'Blue Nun Riesling' ItemDescription, 7.99 supplyPrice, 11.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '089819006526' itemid, 'Beringer White Zinfandel' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089819541874' itemid, 'Beringer Red Moscato' ItemDescription, 7.0 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '791784901736' itemid, 'Our Daily Red' ItemDescription, 9.99 supplyPrice, 13.99 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '8510527' itemid, 'Fre Bru alcohol free' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '080516135144' itemid, 'Riunite Lambrusco' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '727760501331' itemid, 'Mionetto Lambrusco' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8000128193020' itemid, 'Giancarlo Montepulciano' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082734314196' itemid, 'Frontera Chardonnay 4 pack' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089819784639' itemid, 'Beringer White Zinfandel 4 pack' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083804074729' itemid, 'Cooks Spumante' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083804074699' itemid, 'Cook extra dry 4 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '087872633116' itemid, 'Stella Rosa Black 250ml' ItemDescription, 5.75 supplyPrice, 5.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '087872633147' itemid, 'Stella Rosa Platinum 250 ml' ItemDescription, 5.75 supplyPrice, 5.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '848375004588' itemid, 'House wine Red Blend 375ml' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '848375004564' itemid, 'House Wine Chardonnay 375ml' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '848375004991' itemid, 'House wine Rose Bubbles 375ml' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083120103196' itemid, 'Franzia White Zinfandel 5L' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083420127571' itemid, 'Gibson Marsala' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '086036186598' itemid, 'Christian Brothers Meloso Cream Sherry' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '698843131014' itemid, 'Portal Tawny Porto' ItemDescription, 24.99 supplyPrice, 24.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '698843133018' itemid, 'Portal Ruby Porto' ItemDescription, 23.99 supplyPrice, 23.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '080686740131' itemid, 'Cockburns Tawny Porto' ItemDescription, 47.99 supplyPrice, 47.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094799010012' itemid, 'Graham''s Tawny Porto' ItemDescription, 22.99 supplyPrice, 22.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '094799010043' itemid, 'Graham''s 6 Grapes Reserve Porto' ItemDescription, 22.25 supplyPrice, 31.15 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '10000021' itemid, 'Cedar Ridge Port' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089419003178' itemid, 'Warren''s Otima 20 year Tawny Porto' ItemDescription, 52.0 supplyPrice, 52.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '858150004238' itemid, 'McCulley''s Dessert Wine' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '781682114024' itemid, 'Choya Umeshu plum wine' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001461' itemid, 'Cedar Ridge Grain to Glass Sampler' ItemDescription, 33.75 supplyPrice, 46.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001676' itemid, 'Cedar Ridge Bourbon Port cask finish' ItemDescription, 52.0 supplyPrice, 52.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088100134856' itemid, 'Black Velvet Toasted Carmel' ItemDescription, 10.13 supplyPrice, 14.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '088076006232' itemid, 'Dickel Tennessee Sour Mash Whisky' ItemDescription, 29.35 supplyPrice, 29.35 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '856065002974' itemid, 'Deep Eddy ruby red grapefruit vodka' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '050037094480' itemid, 'Disaronno wears Trussadi' ItemDescription, 32.99 supplyPrice, 32.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686034155' itemid, 'Jim Beam Black gift box' ItemDescription, 30.99 supplyPrice, 30.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480983598' itemid, 'St. Germain Spiritz' ItemDescription, 47.99 supplyPrice, 47.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538012836' itemid, 'Jose Cuervo Coconut-Pineapple Marharita' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480230005' itemid, 'Dewar''s White Label Scotch 1.75 L' ItemDescription, 56.65 supplyPrice, 56.65 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088100134511' itemid, 'Black Velvet 1.75 L' ItemDescription, 15.68 supplyPrice, 22.95 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686001102' itemid, 'Jim Beam Bourbon 1.75 L' ItemDescription, 45.09 supplyPrice, 45.09 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082184090428' itemid, 'Jack Daniel''s Whiskey 1.75 L' ItemDescription, 65.43 supplyPrice, 65.43 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000752974' itemid, 'Bullet 95 Rye 1L' ItemDescription, 41.99 supplyPrice, 41.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000789277' itemid, 'Captain Morgan Spiced Rum 1.75 L' ItemDescription, 38.8 supplyPrice, 38.8 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480015206' itemid, 'Bacardi Blanca Rum 1.75 L' ItemDescription, 32.5 supplyPrice, 32.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116014527' itemid, 'UV Blue Vodka 1.75 L' ItemDescription, 24.09 supplyPrice, 24.09 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000727606' itemid, 'Smirnoff Vodka 1.75 L' ItemDescription, 31.98 supplyPrice, 31.98 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686929451' itemid, 'Pinnacle Vodka 1.75 L' ItemDescription, 27.45 supplyPrice, 27.45 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660472614' itemid, 'Barton Vodka 1.75 L' ItemDescription, 15.53 supplyPrice, 15.53 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089016008491' itemid, 'Sobieski Vodka 1.75 L' ItemDescription, 24.09 supplyPrice, 24.09 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '619947000037' itemid, 'Tito''s Vodka 1.75 L' ItemDescription, 39.88 supplyPrice, 39.88 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '720815986046' itemid, 'Seagram''s Vodka 1.75 L' ItemDescription, 16.0 supplyPrice, 21.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538016445' itemid, '1800 Watermelon Margarita 1.75 L' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086785900179' itemid, 'Cinzano Rosso' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086785900209' itemid, 'Cinzano Extra Dry' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'LIQUOR' Class, '080368937019' itemid, 'Mozart Chocolate Cream' ItemDescription, 31.99 supplyPrice, 31.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '841119013068' itemid, 'Battle hill single malt Scotch 22 year' ItemDescription, 128.99 supplyPrice, 128.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001683' itemid, 'Cedar Ridge Lost Pirate' ItemDescription, 48.99 supplyPrice, 48.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538010962' itemid, 'Jose Cuervo Golden Margarita 1.75 L' ItemDescription, 24.18 supplyPrice, 24.18 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089000018758' itemid, 'Chi-chi''s Margarita 1.75 L' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '088110140052' itemid, 'Lagavulin 16 year Scotch' ItemDescription, 76.74 supplyPrice, 99.99 Price, 'DELETED' supplierId UNION 
SELECT 'LIQUOR' Class, '089000019182' itemid, 'Chi-chi''s Strawberry Margarita' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540416373' itemid, 'Kahlua Mudslide 1.75 L' ItemDescription, 17.79 supplyPrice, 17.79 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089000500307' itemid, 'Chi-chi''s Pina Colada' ItemDescription, 10.75 supplyPrice, 15.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '085316860104' itemid, 'Zing 72 Botanical Gin Gift Box' ItemDescription, 29.99 supplyPrice, 29.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086767500069' itemid, 'Goldschlager' ItemDescription, 28.3 supplyPrice, 28.3 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086767704665' itemid, 'Baileys Pumpkim Spice' ItemDescription, 26.99 supplyPrice, 26.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540493398' itemid, 'Kahlua French Vanilla' ItemDescription, 28.99 supplyPrice, 28.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000788133' itemid, 'Smirnoff Love Wins Vodka' ItemDescription, 34.99 supplyPrice, 34.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085592121036' itemid, 'Tequila Rose Strawberry Cream' ItemDescription, 24.99 supplyPrice, 24.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086816124536' itemid, 'Paramount Light Rum 1L' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660000022' itemid, '99 Pepper' ItemDescription, 16.36 supplyPrice, 16.36 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082301750020' itemid, 'Do Q Cristal Rum' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480015305' itemid, 'Bacardi 1 L' ItemDescription, 20.95 supplyPrice, 20.95 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480001520' itemid, 'Bacardi Oakheart Spiced Rum' ItemDescription, 16.75 supplyPrice, 16.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '721094199059' itemid, 'Gosling Black Seal Rum' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '10000022' itemid, 'Captain Morgan Spiced Rum 1 L' ItemDescription, 25.68 supplyPrice, 25.68 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '721059001502' itemid, 'Appleton Estate Signature Blend Rum' ItemDescription, 23.05 supplyPrice, 23.05 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001294' itemid, 'Cedar Ridge Dark Rum' ItemDescription, 35.75 supplyPrice, 35.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '9024153040479' itemid, 'Orchard Apricot' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004015695' itemid, 'Benchmark Egg Nog' ItemDescription, 6.5 supplyPrice, 9.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '083664868377' itemid, 'Sailor Jerry Spice Rum 1 L' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686970132' itemid, 'Cruzan Black Cherry Rum' ItemDescription, 15.35 supplyPrice, 15.35 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480355302' itemid, 'Bacardi Limon 1 L' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '856881004015' itemid, 'Blue Chair Coconut Rum' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540448978' itemid, 'Malibu Coconut Rum 1 L' ItemDescription, 23.04 supplyPrice, 23.04 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '890355001018' itemid, 'Rum Chata 1 L' ItemDescription, 35.31 supplyPrice, 35.31 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '851066003661' itemid, 'Pisa Liqeur' ItemDescription, 27.99 supplyPrice, 27.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352118482' itemid, 'Arrow Peppermint Schnapps 1 L' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004144630' itemid, 'Dr. McGillicuddy''s Raw Vanilla 1 L' ItemDescription, 24.1 supplyPrice, 24.1 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '1744148218' itemid, 'Dr. McGillicuddy''s Cherry 1 L' ItemDescription, 24.1 supplyPrice, 24.1 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004009557' itemid, 'Dr. McGillicuddy''s Wild Grape' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086816600931' itemid, 'Paramount Amaretto 1 L' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086816106532' itemid, 'Paramount Peach Schnapps 1 L' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686319207' itemid, 'DeKuyper   Schnapps 1 L' ItemDescription, 17.53 supplyPrice, 17.53 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686396208' itemid, 'DeKuyper Watermelon  Schnapps 1 L' ItemDescription, 17.53 supplyPrice, 17.53 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686395201' itemid, 'DeKuyper  Sour Apple Schnapps 1 L' ItemDescription, 17.53 supplyPrice, 17.53 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686393207' itemid, 'DeKuyper Grape  Schnapps 1 L' ItemDescription, 17.53 supplyPrice, 17.53 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352118871' itemid, 'Arrow Sloe Gin' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089000604548' itemid, 'Clear Spring grain Alcohol 190 Proof' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352123097' itemid, 'Everclear 151 Proof' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686333029' itemid, 'DeKuyper Creme de Banana Schnapps' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686381204' itemid, 'DeKuyper  Triple Sec 1 L' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116034617' itemid, 'Phillips Rootbeer Schnapps 1 L' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086816100943' itemid, 'Paramount Creme de Cacao' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686391401' itemid, 'DeKuyper  Vanilla Schnapps' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085246139424' itemid, 'Maker''s Mark Whisky 1 L' ItemDescription, 47.28 supplyPrice, 47.28 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001300' itemid, 'Cedar Ridge Bourbon' ItemDescription, 39.01 supplyPrice, 39.01 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686016205' itemid, 'Knob Creek Whiskey 1 L' ItemDescription, 52.81 supplyPrice, 52.81 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '081128001506' itemid, 'Woodford Reserve Bourbon' ItemDescription, 48.24 supplyPrice, 48.24 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686001201' itemid, 'Jim Beam Bourbon 1 L' ItemDescription, 27.45 supplyPrice, 27.45 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '096749021345' itemid, 'Evan Williams Bourbon' ItemDescription, 17.25 supplyPrice, 17.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001553' itemid, 'Short''s Whiskey' ItemDescription, 30.05 supplyPrice, 30.05 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660203034' itemid, 'Trn High Bourbon 1 L' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686821021' itemid, 'Canadian Club' ItemDescription, 21.4 supplyPrice, 21.4 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087000007321' itemid, 'Seagram''s 7 1L' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082184090442' itemid, 'Jack Daniel''s Whiskey 1 L' ItemDescription, 40.68 supplyPrice, 40.68 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088100134535' itemid, 'Black Velvet 1 L' ItemDescription, 15.4 supplyPrice, 15.4 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087000007246' itemid, 'Crown Royal 1 L' ItemDescription, 28.34 supplyPrice, 40.68 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000771586' itemid, 'Crown Royal Regal Apple Whisky 1 L' ItemDescription, 40.68 supplyPrice, 40.68 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000785262' itemid, 'Crown Royal Noble Collection' ItemDescription, 62.99 supplyPrice, 62.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '854396005046' itemid, 'High West Campfire' ItemDescription, 76.99 supplyPrice, 76.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '854396005008' itemid, 'High West Double Rye' ItemDescription, 44.99 supplyPrice, 44.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538011877' itemid, 'Tin Cup Whiskey' ItemDescription, 28.99 supplyPrice, 28.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '720815920101' itemid, 'Templeton Rye Whiskey' ItemDescription, 42.99 supplyPrice, 42.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '898804009004' itemid, 'Slow & Low Rock and Rye' ItemDescription, 26.99 supplyPrice, 26.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080432105993' itemid, 'Green Spot Irish Whiskey' ItemDescription, 74.46 supplyPrice, 74.46 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085254900351' itemid, 'Red Shank Irish Whiskey' ItemDescription, 34.99 supplyPrice, 34.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080432500118' itemid, 'Jameson Irish Whiskey 1 L' ItemDescription, 40.86 supplyPrice, 40.86 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088544018941' itemid, 'Southern Comfort 1 L' ItemDescription, 28.24 supplyPrice, 28.24 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004144678' itemid, 'Fireball Cinnamon Whiskey 1L' ItemDescription, 24.81 supplyPrice, 24.81 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352118604' itemid, 'Arrow Apricot Brandy' ItemDescription, 11.29 supplyPrice, 11.29 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084704000078' itemid, 'Korbel Brandy' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086036815559' itemid, 'Christian Brothers Brandy 1 L' ItemDescription, 11.67 supplyPrice, 16.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '8541800' itemid, 'E&J Brandy 1 L' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086816109144' itemid, 'Paramount Cherry Flavored Brandy' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086816108734' itemid, 'Paramount Blackberry Flavored Brandy 1 L' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001331' itemid, 'Cedar Ridge Apple Brandy' ItemDescription, 40.38 supplyPrice, 40.38 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080432400708' itemid, 'Glenlivet 12 Year Scotch 1 L' ItemDescription, 59.8 supplyPrice, 59.8 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '812066021598' itemid, 'Macallan 12 Year Double Cask' ItemDescription, 66.99 supplyPrice, 66.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088076182783' itemid, 'Johnnie Walker White Walker Scotch' ItemDescription, 48.99 supplyPrice, 48.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '8361073' itemid, 'Glenfiddich 12 Year Scotch' ItemDescription, 49.26 supplyPrice, 49.26 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080432400395' itemid, 'Chivas Regal 12 Year Scotch' ItemDescription, 39.84 supplyPrice, 39.84 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '10000023' itemid, 'Johnnie Walker Red Label Whiskey 1 L' ItemDescription, 36.91 supplyPrice, 36.91 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001317' itemid, 'Cedar Ridge Single Malt Whiskey' ItemDescription, 53.5 supplyPrice, 53.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083664872541' itemid, 'Monkey Shoulder Scotch' ItemDescription, 37.75 supplyPrice, 37.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859141004008' itemid, 'McClelland''s Scotch' ItemDescription, 29.75 supplyPrice, 29.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '747020192413' itemid, 'Benromach 10 YearScotch' ItemDescription, 55.99 supplyPrice, 63.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686813019' itemid, 'Laphroaig 10 year Scotch' ItemDescription, 36.43 supplyPrice, 49.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '867971000305' itemid, 'Holy Hell spiced Rum' ItemDescription, 20.95 supplyPrice, 20.95 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '721059002844' itemid, 'Wild Turkey Longbranch' ItemDescription, 42.0 supplyPrice, 42.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '8220408' itemid, 'Jeremiah Weed 1 L' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '5014218796056' itemid, 'Timorois Beastie Scotch' ItemDescription, 67.99 supplyPrice, 67.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '8007776074473' itemid, 'UV Blue Vodka 1 L' ItemDescription, 16.75 supplyPrice, 16.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116014435' itemid, 'UV Cherry Vodka 1 L' ItemDescription, 16.75 supplyPrice, 16.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116014428' itemid, 'UV Apple Vodka' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000788416' itemid, 'Smirnoff Moscow Mule' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000732914' itemid, 'Smirnoff Blueberry Vodka' ItemDescription, 24.485 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352127156' itemid, 'Pearl Peach Vodka' ItemDescription, 11.5 supplyPrice, 16.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352125275' itemid, 'Pearl Vodka, Cucumber' ItemDescription, 11.5 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '6277551020441' itemid, 'Stolichnaya Stoli Razberi 1 L' ItemDescription, 34.54 supplyPrice, 34.54 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '027724037501' itemid, 'St. George Green Chile Vodka' ItemDescription, 36.99 supplyPrice, 36.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660472638' itemid, 'Barton Vodka 1 L' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '619947000013' itemid, 'Tito''s Vodka 1 L' ItemDescription, 26.56 supplyPrice, 26.56 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085156610419' itemid, 'Ketel One Vodka 1 L' ItemDescription, 35.65 supplyPrice, 35.65 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '22548887' itemid, 'Grey Goose Vodka 1 L' ItemDescription, 48.25 supplyPrice, 48.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088076161863' itemid, 'Ciro Vodka' ItemDescription, 38.99 supplyPrice, 38.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '835229000407' itemid, 'Absolute Vodka 1 L' ItemDescription, 32.49 supplyPrice, 32.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001003' itemid, 'Cedar Ridge Clearheart Vodka' ItemDescription, 26.83 supplyPrice, 26.83 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '649188900483' itemid, 'Grand Marnier 1 L' ItemDescription, 49.96 supplyPrice, 49.96 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686961048' itemid, 'Courvoisier Cognac VS' ItemDescription, 36.27 supplyPrice, 36.27 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686962045' itemid, 'Courvoisier Cognac VSOP' ItemDescription, 44.99 supplyPrice, 44.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083089660150' itemid, 'Jagermeister 1 L' ItemDescription, 33.93 supplyPrice, 33.93 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '689768903008' itemid, 'Magellan Gin' ItemDescription, 35.99 supplyPrice, 35.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '721059987509' itemid, 'Frangelico Liqueur' ItemDescription, 31.45 supplyPrice, 31.45 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540122700' itemid, 'Kahlua Rum & Coffee Liqueur 1 L' ItemDescription, 32.49 supplyPrice, 32.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086767210043' itemid, 'Bailey''s Irish Cream' ItemDescription, 35.65 supplyPrice, 35.65 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000776284' itemid, 'Baileys Almande Liqueur' ItemDescription, 27.25 supplyPrice, 27.25 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '088110110406' itemid, 'Tanqueray Gin 1 L' ItemDescription, 33.55 supplyPrice, 33.55 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480301019' itemid, 'Bombay Sapphire Gin 1 L' ItemDescription, 35.65 supplyPrice, 35.65 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083664868780' itemid, 'Hendrick''s Gin 1 L' ItemDescription, 45.46 supplyPrice, 45.46 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540333489' itemid, 'Beefeater Gin 1 L' ItemDescription, 31.44 supplyPrice, 31.44 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660411330' itemid, 'Barton Gin 1 L' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '897076002003' itemid, 'Bulldog Gin' ItemDescription, 26.99 supplyPrice, 26.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001232' itemid, 'Clearheart Gin' ItemDescription, 26.83 supplyPrice, 26.83 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083300048729' itemid, 'Amarula Cream Liqueur' ItemDescription, 17.64 supplyPrice, 24.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '089000013586' itemid, 'Mr. Boston Rock & Rye' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004005511' itemid, 'Taylor Bourbon' ItemDescription, 68.99 supplyPrice, 68.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '608604000015' itemid, '1921 Blanco Tequila' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '7503018511207' itemid, 'Cupreata Machetazo Mezcal' ItemDescription, 48.99 supplyPrice, 48.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '10000024' itemid, 'Calvados Morin Apple Brandy' ItemDescription, 26.99 supplyPrice, 26.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '10000025' itemid, 'Comisario Reposado Tequila' ItemDescription, 53.99 supplyPrice, 53.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083300032551' itemid, 'Don Eduardo Silver Tequlia' ItemDescription, 47.99 supplyPrice, 47.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686835028' itemid, 'Hornitos Reposado Tequila' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '674545000414' itemid, 'Don Julio Reposado Tequila' ItemDescription, 62.99 supplyPrice, 62.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538010801' itemid, 'Jose Cuervo Especial 1 L' ItemDescription, 28.3 supplyPrice, 28.3 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538010825' itemid, 'Jose Cuervo Silver 1 L' ItemDescription, 28.3 supplyPrice, 28.3 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686832010' itemid, 'Sauza Silver Tequila' ItemDescription, 21.94 supplyPrice, 21.94 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '720815930131' itemid, 'Corralejo Reposado Tequila' ItemDescription, 31.99 supplyPrice, 31.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'LIQUOR' Class, '721733000029' itemid, 'Patron Silver Tequila' ItemDescription, 57.7 supplyPrice, 57.7 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '081240750269' itemid, 'Kah Reposado Tequila' ItemDescription, 69.99 supplyPrice, 69.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '7503013018077' itemid, 'Sotol Silver Tequila' ItemDescription, 52.75 supplyPrice, 52.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '859824001393' itemid, 'Cedar Ridge Age your own Whiskey Kit' ItemDescription, 89.99 supplyPrice, 89.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538010238' itemid, '1800 Reposado Tequila' ItemDescription, 33.47 supplyPrice, 33.47 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083664868919' itemid, 'Milagro Silver Tequila' ItemDescription, 33.99 supplyPrice, 33.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '081753828936' itemid, 'Glenmorange' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '1110470877008' itemid, 'Johnnie Walker Blue Label Whiskey' ItemDescription, 174.0 supplyPrice, 174.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '850483000901' itemid, 'Glen Garioch' ItemDescription, 145.99 supplyPrice, 145.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000003823' itemid, 'Crown Royal XO Whiskey' ItemDescription, 54.99 supplyPrice, 54.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004025984' itemid, 'Tuaca Brandy' ItemDescription, 25.02 supplyPrice, 25.02 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087236210359' itemid, 'Metaxa Ouzo' ItemDescription, 23.05 supplyPrice, 23.05 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480545406' itemid, 'B&B Benedictine' ItemDescription, 41.95 supplyPrice, 41.95 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '083664873623' itemid, 'Drambuie Spiced Whiskey' ItemDescription, 45.8 supplyPrice, 45.8 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087236565107' itemid, 'Cointreau Liqueur' ItemDescription, 45.5 supplyPrice, 45.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660130255' itemid, '90 Meukow Cognac' ItemDescription, 46.99 supplyPrice, 46.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '8004360025309' itemid, 'Bormioli Limoncino Glass 3 pcs' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '898195001014' itemid, 'Fever-Tree Tonic Water 4 pack' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078400000371' itemid, 'Canfield''s Diet Tonic Water 1 L' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078742091532' itemid, 'Diet Tonic Water 1 L' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078742089256' itemid, 'Tonic Water 1 L' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078000218459' itemid, 'Schweppes Tonic Water 1 L' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078742088945' itemid, 'Clear American Lemon Sparkling Water 1 L' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078400000579' itemid, 'Canfield''s Club Soda' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078742087146' itemid, 'Club Soda Low Sodium 1 L' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '1223101' itemid, 'Diet Pepsi 2 L' ItemDescription, 2.69 supplyPrice, 2.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '1223004' itemid, 'Pepsi 2 L' ItemDescription, 2.69 supplyPrice, 2.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '078000000344' itemid, '7up 2 L' ItemDescription, 2.69 supplyPrice, 2.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '049000050110' itemid, 'Diet Coke 2 L' ItemDescription, 2.69 supplyPrice, 2.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '049000050103' itemid, 'Coke 2 L' ItemDescription, 2.69 supplyPrice, 2.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '051000012920' itemid, 'V8 original 12oz' ItemDescription, 1.25 supplyPrice, 1.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '043000041574' itemid, 'Crystal Light Appletini' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '10000026' itemid, 'Betterbody Agave' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '039815110031' itemid, 'Amarena Fabbri wild Cherries' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '089156801914' itemid, 'Santa Barbara Maraschino Cherries' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '038900009472' itemid, 'Dole Pineapple Juice' ItemDescription, 1.25 supplyPrice, 1.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '074865682169' itemid, 'Sahara Burst Cranberry Juice' ItemDescription, 1.25 supplyPrice, 1.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070655901786' itemid, 'Mr & Mrs. T Bloody Mary Mix' ItemDescription, 0.5 supplyPrice, 1.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '031200023636' itemid, 'Ocean Spray Cran Mango 3 L' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '616003814225' itemid, 'ZingZang Bloody Mary Mix' ItemDescription, 4.0 supplyPrice, 5.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'FOOD' Class, '722782477855' itemid, 'Demitris bloody Mary Seasoning Extra Horshradish' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '713035087501' itemid, 'Freshies Bloody Mary Mix Original' ItemDescription, 5.25 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '070655901304' itemid, 'Mr. & Mrs. T Blood Mary Mix 1 L' ItemDescription, 3.83 supplyPrice, 5.75 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'FOOD' Class, '856165004014' itemid, 'Madame Mary Spicy Bloody Mary Mix 1 L' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491571006' itemid, 'Finest Call Michelada 1 L' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491803954' itemid, 'Finest Call Strawberry 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491112209' itemid, 'Finest Call Mango puree 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491554009' itemid, 'Finest Call White Sangria blend 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491113961' itemid, 'Finest Call Raspberry Puree 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491553002' itemid, 'Finest Call Red Sangria 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491569003' itemid, 'Finest Call Single Press Lime Juice 1 L' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '070491114968' itemid, 'Finest Call Lime Juice 1 L' ItemDescription, 3.25 supplyPrice, 5.99 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'FOOD' Class, '070491801950' itemid, 'Finest Call Sweet & Sour 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070491021754' itemid, 'Finest Call Bar Syrup 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '713035087617' itemid, 'Freshies Tangerita' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '713035087556' itemid, 'Freshies Peach-Mango' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '1660433' itemid, 'Rose''s Sweetened Lime Juice 12 oz' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '016600000739' itemid, 'Rose''s Sweetened Lime Juice' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '4124467' itemid, 'Martinellis Sparkling Cider' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '041800716005' itemid, 'Welch''s Sparkling Red Grape' ItemDescription, 2.5 supplyPrice, 4.99 Price, 'SAM''S' supplierId UNION 
SELECT 'SODA' Class, '041800704200' itemid, 'Welch''s Sparkling Cranberry' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '041800704194' itemid, 'Welch''s Sparkling Blueberry' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '041800715008' itemid, 'Welch''s Sparkling White Grape' ItemDescription, 2.5 supplyPrice, 4.99 Price, 'SAM''S' supplierId UNION 
SELECT 'SODA' Class, '070491807952' itemid, 'Finest Call Grenadine 1 L' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083648842584' itemid, 'Elk Cove Pinot Blanc' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '023604305005' itemid, 'Twang Bloody Mary Salt' ItemDescription, 4.89 supplyPrice, 4.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '023604301007' itemid, 'Twang a Rita Salt' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '076381123454' itemid, 'Jose Cuervo Margarita Salt' ItemDescription, 2.99 supplyPrice, 5.99 Price, 'NONE' supplierId UNION 
SELECT 'LIQUOR' Class, '080686931348' itemid, 'Pinnacle Peach Vodka 200 mL' ItemDescription, 3.75 supplyPrice, 4.99 Price, 'DELETED' supplierId UNION 
SELECT 'LIQUOR' Class, '088100134573' itemid, 'Black Velvet 375 mL' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'DELETED' supplierId UNION 
SELECT 'LIQUOR' Class, '8776509' itemid, 'Seagram''s 7 Whiskey 375 mL' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '736040506898' itemid, 'Nuvo Sparkling Liqueur' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084380360947' itemid, 'Pennsylvania Dutch Eggnog' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686006886' itemid, 'Jim Beam Vanilla 100 mL' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277779144' itemid, 'Hot Glasses 24 pack' ItemDescription, 2.89 supplyPrice, 2.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '813515010859' itemid, 'Savvi Serve Shot Glass 50 ct' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718004322' itemid, 'True tools Champaign Stopper' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718007071' itemid, 'True Chalice Stopper' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '4000530485960' itemid, 'Weinflaschenverdchluss' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '024055210825' itemid, 'Name Your Drink Tags' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757901003' itemid, 'Epic Champagne Stopper' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '79094726' itemid, 'Fliptop Pourer' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277237644' itemid, 'Coffee Stirrers 250 cnt' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '028588024010' itemid, 'Plate Clips 4 cnt' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '028588004081' itemid, 'Frilly Party Picks' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277161529' itemid, 'Water''s Corkscrew' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '090782256115' itemid, 'Stainless steel wine collar' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '10000027' itemid, 'Wine collector Martini pics' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '10000028' itemid, 'Birthday candles 60' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4141877' itemid, 'Burman''s Hot sauce' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '011034500053' itemid, 'Martini & Rossi Asti Sparkling Wine' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '017224712107' itemid, 'Caymus Cabernet Sauvignon 2016' ItemDescription, 84.99 supplyPrice, 84.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000029' itemid, 'Velvet Glove' ItemDescription, 180.0 supplyPrice, 180.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '081753814090' itemid, 'Nvmanthia' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '017224720102' itemid, 'Caymus special selection Cabernet Sauvignon 2014' ItemDescription, 179.99 supplyPrice, 179.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089419212150' itemid, 'Chateau de Beacastel' ItemDescription, 99.99 supplyPrice, 99.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089819732623' itemid, 'Beringer Knights Valley Reserve Cabernet Sauvignon' ItemDescription, 62.99 supplyPrice, 62.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083085003517' itemid, 'Quintessa Napa Valley Red 375 mL' ItemDescription, 89.99 supplyPrice, 89.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '3760200090818' itemid, 'Gevrey-Chambertin Petit Chapelle 1er Cru' ItemDescription, 99.99 supplyPrice, 99.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8187114' itemid, 'Terre Rouge Syrah' ItemDescription, 39.99 supplyPrice, 39.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000030' itemid, 'Silver Oak Cabernet Sauvignon Alexander Valley' ItemDescription, 79.99 supplyPrice, 79.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000031' itemid, 'Silver Oak Napa Valley Cabernet Sauvignon' ItemDescription, 124.99 supplyPrice, 124.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '9336975000020' itemid, 'Mollydooker Enchanted Path 2011' ItemDescription, 79.99 supplyPrice, 79.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '669576019283' itemid, 'Duckhorn Napa Valley Merlot 2014' ItemDescription, 40.0 supplyPrice, 54.0 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'WINE' Class, '011628375012' itemid, 'Whitehall Lane Napa Valley Cabernet Sauvignon 2010' ItemDescription, 24.99 supplyPrice, 24.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082491070137' itemid, 'Mariner Dry Creek Maritage 2006 1.5 L' ItemDescription, 89.99 supplyPrice, 89.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000032' itemid, 'Venge Bone Ash Napa Cabernet Sauvignon' ItemDescription, 115.0 supplyPrice, 115.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085592138553' itemid, '360 Double Chocolate vodka' ItemDescription, 11.5 supplyPrice, 16.99 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '811538018760' itemid, 'Jose Cuervo Rose Margarita 1.75 L' ItemDescription, 24.99 supplyPrice, 24.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '7809590500012' itemid, 'Antiyal chili red blend' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '806145000109' itemid, 'Altos Las Hormigas Mendoza Malbec' ItemDescription, 79.99 supplyPrice, 79.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000033' itemid, 'Bien Nacido Syrah' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '033293655008' itemid, 'Segura Viudas' ItemDescription, 48.99 supplyPrice, 48.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000034' itemid, 'Cakebread Cellars Napa Valley Chardonnay' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089819003358' itemid, 'Beringer' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000035' itemid, 'Pahlmeyer Napa Chardonnay' ItemDescription, 72.99 supplyPrice, 72.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '690300550611' itemid, 'Craggy Ridge Pinot Noir' ItemDescription, 44.99 supplyPrice, 44.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '632987200052' itemid, 'Santa Margherita Pinot Grigio 375 mL' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087000700703' itemid, 'Seagram''s 7 Whiskey 1.75 L' ItemDescription, 27.76 supplyPrice, 27.76 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082184090510' itemid, 'Jack Daniel''s Whiskey 375 mL' ItemDescription, 11.25 supplyPrice, 15.75 Price, 'DELETED' supplierId UNION 
SELECT 'WINE' Class, '044956001018' itemid, 'ZD Chardonnay' ItemDescription, 38.99 supplyPrice, 38.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '733555351326' itemid, 'Chateau Montelena Chardonnay' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084380360961' itemid, 'Pennsylvania Dutch 200 mL' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '14173783' itemid, 'Hogue Riesling' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480230012' itemid, 'Dewar''s White Label Scotch 1 L' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'DELETED' supplierId UNION 
SELECT 'GIFT' Class, '10000036' itemid, 'BigMoutch xl Wine Glass 750 mL' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757751233' itemid, 'Epic Keep it Hot Sake Set' ItemDescription, 21.99 supplyPrice, 21.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '077190001407' itemid, 'Snoqualmie Riesing' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '81050031' itemid, 'Richard Grant Pinot Noir' ItemDescription, 32.99 supplyPrice, 32.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '081753822422' itemid, 'Moet et Chandon Champagne Dom Perignon' ItemDescription, 199.99 supplyPrice, 199.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '811416001808' itemid, 'Charles Baur Cremant D''Alsace' ItemDescription, 14.5 supplyPrice, 22.99 Price, 'BEST CASE WINES' supplierId UNION 
SELECT 'WINE' Class, '701253004011' itemid, 'Gruet Demi sec Sparking Wine 375 mL' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '10000037' itemid, 'Vollereaux Champagne Brut 375 mL' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '083804074507' itemid, 'Cook''s Extra Dry Sparkling Wine 187 mL' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '896383000016' itemid, 'Ca''del Bosco Franciacorta Cuvee Prestige' ItemDescription, 41.99 supplyPrice, 41.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '724624114010' itemid, 'J Cuvee 20' ItemDescription, 36.99 supplyPrice, 36.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '084692501649' itemid, 'Taitinger Champagne Brut' ItemDescription, 62.99 supplyPrice, 62.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '081753050207' itemid, 'Veuve Clicquot Champagne Brut' ItemDescription, 51.55 supplyPrice, 71.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'LIQUOR' Class, '665203200604' itemid, 'Merry Irish Cream gift Boc' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352127194' itemid, 'Pearl Vodka, Wedding two Pack' ItemDescription, 39.99 supplyPrice, 39.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '8714793388239' itemid, 'Vacu Vin Active Wine Cooler 2 pack' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '614036124113' itemid, 'New Holland Dragon''s Milk Stout 4 pack' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '094922437471' itemid, 'Dirty Blonde Chocolate Ale 4 pack' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '793866360028' itemid, 'Left Hand Milk Stout 6 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '860342001505' itemid, 'Singlespeed Tip the Cow 6-pack Cans' ItemDescription, 7.8 supplyPrice, 11.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'SODA' Class, '072924012049' itemid, 'Cock ''n Bull Ginger beer 4 pack' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '605800000184' itemid, 'Old Speckled Hen English Ale 4 Pack' ItemDescription, 12.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '793573765147' itemid, 'Roller Dam Red 4 Pack' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '746546000783' itemid, 'Lakefront New Grist Ginger Ale 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '9450040253' itemid, 'Saranac Ginger Beer' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '891236001042' itemid, 'Regatta Ginger Beer 6 pack' ItemDescription, 6.25 supplyPrice, 8.99 Price, 'I-BEV' supplierId UNION 
SELECT 'SODA' Class, '049000067217' itemid, 'Coke mini 10 pack' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '758913883349' itemid, 'Lion Bridge Compensation English Ale 6 pack' ItemDescription, 8.75 supplyPrice, 12.99 Price, 'I-BEV' supplierId UNION 
SELECT 'BEER' Class, '893354001027' itemid, 'Surly Furious IPA 4pack' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '850992005237' itemid, 'Exile Beatnik Sour Ale 6 pack' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '220222617040' itemid, 'Dogfish Head 60 Minute IPA 6 pack' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '088573331011' itemid, 'Shiner Bock 6 pack' ItemDescription, 8.05 supplyPrice, 10.99 Price, 'I-BEV' supplierId UNION 
SELECT 'BEER' Class, '786150000304' itemid, 'Leffe Blonde Ale 6 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '092000013067' itemid, 'TsingTao Lager 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '851626003018' itemid, 'Lucky Buddha 6 pack' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'BEER' Class, '700283010030' itemid, 'Moose Drool Brown Ale 6 Pack' ItemDescription, 10.25 supplyPrice, 10.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '080660959351' itemid, 'St. Pauli Girl Lager 6 Pack' ItemDescription, 9.99 supplyPrice, 9.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '726959909774' itemid, 'Dark Truth Imperial Stout' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '015925346218' itemid, 'Back Road Stout 6 Pack' ItemDescription, 7.25 supplyPrice, 10.99 Price, 'DELETED' supplierId UNION 
SELECT 'BEER' Class, '810631030020' itemid, 'Exile Bohemian Fruit Revue Sour Ale' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '073360512049' itemid, 'Mississippi Mud Black & Tan 1 quart' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '736920111822' itemid, '312 wheat Ale' ItemDescription, 10.99 supplyPrice, 10.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '852380004204' itemid, 'Wilson Orchard Peach Fizz 4 Pack' ItemDescription, 11.75 supplyPrice, 11.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '815833002028' itemid, 'Czechvar Lager 6 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '815833002004' itemid, 'Czechvar Lager' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852380004198' itemid, 'Wilson''s Orchard Peach Fizz single' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '736920111815' itemid, 'Goose 312 Wheat Ale single' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852380004266' itemid, 'Sutliff Cider 6 Pack' ItemDescription, 12.99 supplyPrice, 12.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '033544950517' itemid, 'Corona Familiar Lager 6 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '033544950555' itemid, 'Corona Familiar' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852380004211' itemid, 'Wilson''s Orchard Old Blue 4 Pack' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852380004228' itemid, 'Wilson''s Orchard Old Blue Blueberry Cider' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '088733900224' itemid, 'Cider Boys Tiki Colada' ItemDescription, 7.72 supplyPrice, 10.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '088733900217' itemid, 'Cider boys Cranberry Road CranApple Cider' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200200793' itemid, 'Bud Light Orange Lager 6 Pack' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200259029' itemid, 'Bud Light Orange Lager' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852380004143' itemid, 'Wilson''s Orchard Spiced Up Cider 4 Pack' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '9031104614771' itemid, 'Wilson''s Orchard Spiced Up Cider' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '015925321680' itemid, 'Millstream Schokolade Bock' ItemDescription, 7.25 supplyPrice, 10.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '015024626211' itemid, 'Fuzz Peach Kolch' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '034100516055' itemid, 'Leinenkugel''s Summer Shandy 6 Pack' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '3477414' itemid, 'Leinenkugel''s Summer Shandy' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '850992005046' itemid, 'Exile Hannah Bavarian Wheat 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '850992005039' itemid, 'Exile Hannah Bavarian Wheat' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852211003321' itemid, 'Pseudo Sue Pale Ale 4 Pack' ItemDescription, 9.0 supplyPrice, 11.99 Price, 'JOHNSON BROTHERS' supplierId UNION 
SELECT 'BEER' Class, '018200129827' itemid, 'Land Shark Lager 6 Pack' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '1877928' itemid, 'Land Shark Lager' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '856411002191' itemid, 'Blonde Fatale Blonde Ale 6 Pack' ItemDescription, 9.5 supplyPrice, 13.99 Price, 'I-BEV' supplierId UNION 
SELECT 'BEER' Class, '856411002184' itemid, 'Blonde Fatale Blonde Ale' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '810458030647' itemid, 'Pseudo Sue Pale' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '635985258759' itemid, 'Mike''s Harder Lemonade' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '085725422139' itemid, 'Ayinger Oktober Fest 4 Pack' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '085725122138' itemid, 'Ayinger Oktober Fest' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '034100087166' itemid, 'Redd''s Apple Ale 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '3477113' itemid, 'Redd''s Apple Ale' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852211003277' itemid, 'Dorothy''s Lager 4 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852131004347' itemid, 'Murderhorn Belgian Ale 6 pack' ItemDescription, 7.99 supplyPrice, 11.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '852131004354' itemid, 'Murderhorn Golden Ale' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852131004040' itemid, 'Slingshot Dunkel 6 pack' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852131004002' itemid, 'Slingshot Dunkel' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852131004415' itemid, 'Raygun IPA 6 Pack' ItemDescription, 7.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852131004149' itemid, 'Raygun IPA' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '080660956053' itemid, 'Corona Extra Lager 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '8066145' itemid, 'Corona Extra Lager single' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '786150000014' itemid, 'Stella Artois 6 Pack' ItemDescription, 10.5 supplyPrice, 10.5 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '786150000052' itemid, 'Stella Artois' ItemDescription, 10.5 supplyPrice, 10.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '638489000695' itemid, 'Dogfish Head Burton Baton 4 Pack' ItemDescription, 16.8 supplyPrice, 16.8 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '638489000671' itemid, 'Dogfish Head Burton Baton' ItemDescription, 16.8 supplyPrice, 16.8 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '083783381023' itemid, 'Torpedo Extra Pale Ale 12 Pack' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200530470' itemid, 'Bud Light 12 Pack Cans' ItemDescription, 10.98 supplyPrice, 14.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '034100576530' itemid, 'Miller Lite 16oz 12 Pack' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200008016' itemid, 'Busch Lite 12 Pack' ItemDescription, 13.99 supplyPrice, 14.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '034100176365' itemid, 'Miller Genuine Draft 12 Pack' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '071990095116' itemid, 'Blue moon 6 Pack' ItemDescription, 7.25 supplyPrice, 10.99 Price, 'I-BEV' supplierId UNION 
SELECT 'BEER' Class, '8787337' itemid, 'Blue Moon' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200139864' itemid, 'Shock Top 6 Pack' ItemDescription, 7.5 supplyPrice, 10.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '018200008672' itemid, 'Shock Top' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '754527000226' itemid, 'Fat Tire 6 pack' ItemDescription, 10.5 supplyPrice, 10.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '754527000219' itemid, 'Fat Tire' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '088733900026' itemid, 'Cider Boys First Press' ItemDescription, 10.75 supplyPrice, 10.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '088733900019' itemid, 'Cider Boys First Press' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '737398018200' itemid, 'Aventinus Dobbelbock Ale' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '608359005006' itemid, 'Hobgoblin English Ale 4 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '083820725537' itemid, 'Guinness Kaliber 6 Pack' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '083820725520' itemid, 'Guinness Kaliber' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '072890100115' itemid, 'Amstel Light' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '7289848' itemid, 'Amstel Light' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '853897002318' itemid, 'Spiked Seltzer Grapefruit 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '854781004548' itemid, 'Mary me bloody Mary Party Set' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '8573810' itemid, 'Lindemann Gift Box' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '895531002292' itemid, 'Buffalo Sweat Oatmeal Stout 1' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '728028438239' itemid, 'Cherry Bomb Blonde 4 Pack' ItemDescription, 6.99 supplyPrice, 10.99 Price, 'I-BEV' supplierId UNION 
SELECT 'BEER' Class, '763176800019' itemid, 'Jubelale Winter Ale' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '082184000915' itemid, 'Jack Daniel''s Watermelon Punch' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '852421006341' itemid, 'Hi ball Energy Wildberry Energy Water' ItemDescription, 0.0 supplyPrice, 0.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '819538005131' itemid, 'Holy Grail Amber Ale' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '853797003262' itemid, 'Joia Spirt Sparkling Greyhound 4 Pack' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200229893' itemid, 'Mang-o-rita Mango Margarita 12 Pack' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200229923' itemid, 'Pomegranate-Rita 12 pack' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200199875' itemid, 'Lime-a-Rita Classic Margarita 12 Pack' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200970078' itemid, 'Lemon-ade-Rita Margarita 12 pack' ItemDescription, 17.99 supplyPrice, 17.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '1823024' itemid, 'Chelada 6 pack' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '1886625' itemid, 'Chelada 16oz 4 pack' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '611269818994' itemid, 'Red Bull 12oz' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '893354001157' itemid, 'Blakkr Imperial Black Ale 4 Pack' ItemDescription, 18.9 supplyPrice, 18.9 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, 'PORTAVITA' itemid, 'Portavita' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '098709300132' itemid, 'Prager Gruner Veltliner' ItemDescription, 29.99 supplyPrice, 29.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, 'SMALL ICE' itemid, 'Ice, Small' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, 'LARGE ICE' itemid, 'Ice, Large' ItemDescription, 4.0 supplyPrice, 5.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, 'BOTTLE DEPOSIT' itemid, 'Bottle Deposit' ItemDescription, 0.1 supplyPrice, 0.1 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4 BOTTLE DEPOSIT' itemid, '4 Pack Bottle Deposit' ItemDescription, 0.2 supplyPrice, 0.2 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '6 BOTTLE DEPOSIT' itemid, '6 Pack Bottle Deposit' ItemDescription, 0.3 supplyPrice, 0.3 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '752830090583' itemid, 'Big Grove Summer Jam 4pack' ItemDescription, 7.5 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200149917' itemid, 'Bud light Lime 6 pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'BEER' Class, '728028451535' itemid, 'Tank Puncher IPA 6 pack' ItemDescription, 9.0 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '009450040253' itemid, 'Saranac Ginger Beer' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '616003559928' itemid, 'ZingZang 6 pack' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '726959911074' itemid, 'Boulevard Space Camper' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, 'GRAD CARD' itemid, '3.75' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, 'GIFT CARD' itemid, 'Gift Card' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, 'SINGLE BEER' itemid, 'Beer, Single' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, 'BEER MIXED 6 PACK' itemid, 'Beer, Mixed 6 Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '084543800075' itemid, 'Singha 6 Pack' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '790586130122' itemid, 'Yeti Imperial Stout' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '852131004057' itemid, 'Gold Coin' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '810845005364' itemid, 'Van Ruiten Shiraz' ItemDescription, 24.99 supplyPrice, 24.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '753526300009' itemid, 'FireSteed Riesling' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '767749002282' itemid, 'The Stump Jump White' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '732458960970' itemid, 'Saintsbury' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '659994001205' itemid, 'Campus Oaks' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '752830777163' itemid, 'Big Grove IPA' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '853897002288' itemid, 'Spiked Seltzer' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '087692006862' itemid, 'Truly Berry Mix Pack' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '811538013307' itemid, 'Jose Cuervo' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '856895003950' itemid, 'Golden Road Melon Cart' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '726959901204' itemid, 'Boulevard Unfiltered Wheat Beer' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '072799830564' itemid, 'Moser Roth Dark 70%' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'ALDIS' supplierId UNION 
SELECT 'FOOD' Class, '072799830694' itemid, 'Moser Roth Milk Toffe Crunch' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'ALDIS' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '072799830687' itemid, 'Moser Roth Dark Almond' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '072799762896' itemid, 'Moser Roth Dark Mint/' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'ALDIS' supplierId UNION 
SELECT 'CUSTOM' Class, '072799830298' itemid, 'chocolate bar' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '072799441098' itemid, 'Moser Roth Dark Sea Salt Caramel' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'ALDIS' supplierId UNION 
SELECT 'FOOD' Class, '072799830380' itemid, 'Moser Roth Peru 62%' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '072799762889' itemid, 'Moser Roth Dark Chili' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '072799830717' itemid, 'Moser Roth Dark 85%' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'ALDIS' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '072799830540' itemid, 'Moser Roth Milk' ItemDescription, 2.99 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '072799830397' itemid, 'Moser Roth Dominican Republic 75%' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '856481003883' itemid, 'Lily''s 85% Dark Chocolate' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '053035036407' itemid, 'Schogetten' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498239855' itemid, 'Artisan Crackers Rosemary' ItemDescription, 5.25 supplyPrice, 5.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100000726' itemid, 'Scalloped Crackers Sea Salt' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041396000977' itemid, 'Candy Lights' ItemDescription, 0.5 supplyPrice, 0.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '072890000118' itemid, 'Heineken' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '796030314995' itemid, 'Koko Brown' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200059896' itemid, 'Michelob Ultra 6-pack Bottles' ItemDescription, 7.73 supplyPrice, 10.99 Price, '7G BEER DISTRIBUTORS' supplierId UNION 
SELECT 'FOOD' Class, '034000291199' itemid, 'Smores Kit' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '030100119630' itemid, 'Toasteds Harvest Wheat' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '030100119616' itemid, 'Toasteds Sesame' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '030100322924' itemid, 'Toasteds Buttercrisp' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '858201006013' itemid, 'LED Lite Flite' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '858218007874' itemid, 'Crespini' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498110895' itemid, 'Savoritz' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498110918' itemid, 'Savoritz' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285300579' itemid, 'Amana Beef Sticks' ItemDescription, 5.79 supplyPrice, 5.79 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285300142' itemid, 'Amana Summer Sausage, Double Smoke' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'AMANA SMOKEHOUSE' supplierId UNION 
SELECT 'FOOD' Class, '021285300135' itemid, 'Amana Summer Sausage, Traditional' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277217066' itemid, 'Portable wine Glass' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757752001' itemid, 'Cheese Knives' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '20061111' itemid, 'Cheese knife Set, Metal' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '20061104' itemid, 'Cheese Knive Set, Black' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285004507' itemid, 'Amana Summer Sausage, Old World' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285006099' itemid, 'Amana Roasted Field Corn' ItemDescription, 3.5 supplyPrice, 3.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285007041' itemid, 'Amana Caramel Corn Nuts' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '602050010871' itemid, 'Hatch Valley Salsa, Med' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '721874009905' itemid, 'Pop Rocks 3 Pack' ItemDescription, 1.25 supplyPrice, 2.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '028400244251' itemid, 'Lay''s Chips, Beer Cheese' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '040000541103' itemid, 'Bottle of Candy' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498165680' itemid, 'Clancy''s Chips, Hint of Lime' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '014272466259' itemid, 'Creamy Delight Hard Candy' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277962447' itemid, 'Birthday Candles' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '077260097095' itemid, 'Russell Stover Mint Patties' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277122360' itemid, 'Candle, 60 count' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100030426' itemid, 'Mature Cheddar with Balsmic Red Onion' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '835229001039' itemid, 'small vodka' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08247201' itemid, 'Smironoff 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498149147' itemid, 'Edam, Specially Selected' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498116033' itemid, 'Goat Cheese, Honey' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498115654' itemid, 'Goat Cheese, Plain' ItemDescription, 2.75 supplyPrice, 3.99 Price, 'ALDIS' supplierId UNION 
SELECT 'FOOD' Class, '078354719183' itemid, 'Habanero Cheddar Cheese, Cabot' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498212780' itemid, 'Extra Sharp Chedder, Cracker Cuts' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100018448' itemid, 'Sparkling Wine Cheese, Specially Selected' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100018417' itemid, 'Red Wine Cheese, Specially Selected' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '813039020204' itemid, 'Olli Genoa Mild Salame' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '736547566715' itemid, 'Roth Grand Cru Alpine-style Cheese' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100031003' itemid, 'Happy Farms Fondue' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498193539' itemid, 'Happy Farms Cream Cheese' ItemDescription, 2.79 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '086824312802' itemid, 'Jimmy''s Dill Vegetable Dip' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '890355001209' itemid, 'Tippy Cow Variety Pack' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '719410720018' itemid, '5-Hour Energy, Extra Strength' ItemDescription, 2.89 supplyPrice, 2.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '684746355107' itemid, 'Johny Bootlegger, Raspberry' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '082734314097' itemid, 'Frontera Chargonnay 187ml' ItemDescription, 2.79 supplyPrice, 2.79 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '812459010697' itemid, 'Bird Dog Peach Whiskey 50ml' ItemDescription, 1.89 supplyPrice, 1.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '898432002477' itemid, 'Dulce Vida Lime' ItemDescription, 27.99 supplyPrice, 27.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '890355001049' itemid, 'Rum Chata' ItemDescription, 1.33 supplyPrice, 1.99 Price, 'IA ALCOHOLIC BEVERAGES' supplierId UNION 
SELECT 'DEPOSIT' Class, 'BOTTLE DEPOSIT 6 PACK' itemid, 'Bottle Deposit X 6' ItemDescription, 0.3 supplyPrice, 0.3 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480016210' itemid, 'Bacardi Supior 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540453927' itemid, 'Malibu Coconut Rum 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000005582' itemid, 'Bailey''s Strawberries & Cream 50ml' ItemDescription, 3.5 supplyPrice, 3.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '08500229' itemid, 'Sutter Home Merlot 187ml' ItemDescription, 2.79 supplyPrice, 2.79 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '853452003156' itemid, 'Forbidden Secret Darm Mocha 50ml' ItemDescription, 3.5 supplyPrice, 3.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '179943622041' itemid, 'Fabulous Flask 147ml' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08252009' itemid, 'Bailys Almande 50ml' ItemDescription, 3.25 supplyPrice, 3.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089540122748' itemid, 'Kuhlua 50ml' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, 'HOT SOPRESSATA' itemid, 'hot Sopressata' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352117539' itemid, 'Arrow Peppermint Schnapps 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086767210128' itemid, 'Bailey''s 50ml' ItemDescription, 3.75 supplyPrice, 3.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352132020' itemid, 'Exra Brooks Bourbon Cream 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '835229000742' itemid, 'Absolute Wild Tea 50ml' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08247803' itemid, 'Captain Morgan Cannon Blast 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080660010700' itemid, '99 Pinapples Liquer 50ml' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '089105870022' itemid, 'Uncle Bob''s Root beer Whiskey' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686006367' itemid, 'Jim Beam Kentuky Fire 50ml' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '720815980402' itemid, 'Seagrams Watermelon Vodka 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '619947000068' itemid, 'Tito''s Vodka 50ml' ItemDescription, 2.5 supplyPrice, 2.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085156404957' itemid, 'Ketel One Vodka 50ml' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '086036100198' itemid, 'Christian Brothers VS Brandy 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080432500101' itemid, 'Jameson Irish Whiskey 50ml' ItemDescription, 3.75 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '835229000001' itemid, 'Absolute Vodka 50ml' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004020972' itemid, 'Tijuana Sweet Heat 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084279993553' itemid, 'Rondiaz Spicke Black Cherry Rum 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '085592121081' itemid, 'Tequila Rose Strawberry Cream 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '811538010948' itemid, 'Jose Cuervo Gold 50ml' ItemDescription, 2.75 supplyPrice, 2.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088544000021' itemid, 'Southern Comfort 50ml' ItemDescription, 1.5 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08731409' itemid, 'Captain Morgan Spiced Rum 50ml' ItemDescription, 1.5 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116015470' itemid, 'UV Cake Vodka 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08563404' itemid, 'New Amserdam Mango Vodka 50ml' ItemDescription, 1.95 supplyPrice, 1.95 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08240004' itemid, 'Smirnoff Raspberry 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116000445' itemid, 'UV Ruby Red Vodka 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352127941' itemid, 'Pearl Chocolate Covered Cherry Vodka 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '856065002110' itemid, 'Deep Eddy Ruby Red Vodka 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '856065002158' itemid, 'Deep Eddy Cranberry Vodka 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '748252054036' itemid, 'Wine Diamonds DVD' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '797642747676' itemid, 'Hat, Weekend' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '026217261485' itemid, 'Hat, Drink Local' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '026217261201' itemid, 'Hat, Best Dad Ever' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '026217261133' itemid, 'Hat, Total Dad Move' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '041498340506' itemid, 'Bread Knife & Cutting Board' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277232571' itemid, 'Goofy String' ItemDescription, 2.49 supplyPrice, 2.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277232557' itemid, 'Goofy String' ItemDescription, 2.49 supplyPrice, 2.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277355362' itemid, 'Glow Play Bracelets 20 pcs' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277355348' itemid, 'Glow Play Bracelets 20 pcs' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '709996760966' itemid, 'Sharper Image Bar Cutting Board' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277400987' itemid, 'Coin Purse' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '040000424314' itemid, 'Snickers' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '04097002' itemid, 'StarBurst' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '040000508830' itemid, 'M&M, Carmamel' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '04016308' itemid, 'Skittles, Tropical' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '04016007' itemid, 'Skittles' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '04003100' itemid, 'M&M' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '02289106' itemid, 'Extra, Peppermint' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '02289902' itemid, 'Extra, Spearmint' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '03424005' itemid, 'Hershey''s Milk Chocolate' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '022000013316' itemid, 'Eclips Spearmint' ItemDescription, 1.59 supplyPrice, 1.59 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '022000013200' itemid, 'Eclipse, Winterfrost' ItemDescription, 1.59 supplyPrice, 1.59 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '855378004125' itemid, 'Alli&Rose Dark Chocolate Pomegranate' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '022000013279' itemid, 'Eclipse, Polar Ice' ItemDescription, 1.59 supplyPrice, 1.59 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '02289805' itemid, 'Extra, Polar Ice' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '040000525028' itemid, 'Dove Milk Cocolate' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '034000376124' itemid, 'Rolo' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '012546685016' itemid, 'ID BerryMelon' ItemDescription, 1.89 supplyPrice, 1.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '012546619592' itemid, 'Trident Tropical Twist' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '012546612296' itemid, 'Trident Gum' ItemDescription, 1.49 supplyPrice, 1.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100018431' itemid, 'Cocktail Stirrers, Spicy' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '017082000033' itemid, 'Jack Link''s, Original' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '017082885166' itemid, 'Jack Link''s Beef Stips' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '028400055987' itemid, 'Tostitos Salsa, Med' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498145095' itemid, 'Casa Mamita Salsa, Med' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498115982' itemid, 'Specially Selected, Black Bean & Corn Salsa' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498193195' itemid, 'Casa Mamita Con Queso' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498266363' itemid, 'Mango Chutney' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '890791000460' itemid, 'Brie Cheese Spread' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '890791000446' itemid, 'Camembert Cheese Spread' ItemDescription, 4.5 supplyPrice, 4.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '035549970781' itemid, 'McGinnis Shortbread Fingers' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '852832105848' itemid, 'Gran Campo Viejo Caba Brut Rose' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '405580018399' itemid, 'Schwarzhow' ItemDescription, 20.99 supplyPrice, 20.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '859367003847' itemid, 'Woop Woop Cabernet' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088110551025' itemid, 'Mini Moet 187ml' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '085155001010' itemid, 'Chandon Brut 187ml' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899911000854' itemid, 'New Age Sweet Gold' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '089121058527' itemid, 'Cypress Chardonnay' ItemDescription, 9.5 supplyPrice, 9.5 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '851645004126' itemid, 'Locations E' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '899552001197' itemid, 'Pacific Rim Dry Riesling' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '890751000967' itemid, 'The Big Mouth' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '853013003021' itemid, 'Helwig Round up Red' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '081054064958' itemid, 'Napa Ridge Cabernet' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '130227059823' itemid, 'La Romantica Permonte Branchetto' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '817421001093' itemid, 'The Corker Dessert Wine' ItemDescription, 6.0 supplyPrice, 11.99 Price, 'GLOBAL WINES' supplierId UNION 
SELECT 'WINE' Class, '852195001146' itemid, 'Hannah Nicole Zinfandel' ItemDescription, 12.99 supplyPrice, 12.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352116907' itemid, 'Old Medley Bourbon Whiskey 12 Year' ItemDescription, 68.99 supplyPrice, 68.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '040063400027' itemid, 'Four Roses Single Barrel' ItemDescription, 42.99 supplyPrice, 42.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '088790216481' itemid, 'Stone Hill Pink Catawba' ItemDescription, 7.75 supplyPrice, 7.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '857151003387' itemid, 'Wine Sisterhood' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '084002000121' itemid, 'Hinman Sweet Rose' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '08257208' itemid, 'Captain Morgan Apple Smash 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352131498' itemid, 'Rebel Yell Root Beer' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088352115368' itemid, 'Extra Brooks Bourbon 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '087116001732' itemid, 'Revel Stoke' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080686119074' itemid, 'Pucker Cherry Vodka' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080480007201' itemid, 'Bacardi White Rum 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084279996684' itemid, 'Kinky Green Vodka 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084279985978' itemid, 'Kinky Pink Vodka 50ml' ItemDescription, 1.85 supplyPrice, 1.85 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '084279002118' itemid, 'Kinky Aloha Vodka 50ml' ItemDescription, 1.75 supplyPrice, 1.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004009755' itemid, 'Dr. McGillicuddy''s Apple Pie 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004009793' itemid, 'Dr. McGillicuddy''s Peach 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '088004148263' itemid, 'Dr. McGillicuddy''s Cherry 50ml' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718008320' itemid, 'Napkins' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757830501' itemid, 'My Glass Charms' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '067742493538' itemid, 'Fun on Glass' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '747585306126' itemid, 'Wine Marker' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '749258700101' itemid, 'Gemware' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '028588490082' itemid, 'Cork Trivet Kit' ItemDescription, 16.99 supplyPrice, 16.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '728987012785' itemid, 'Fred Wine Lines, Subtle' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '840341541332' itemid, 'Rhinestone Words' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718001307' itemid, 'True Wine Gift Bag Red Sheer' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718001666' itemid, 'True Wine Gift back Sheer Green' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757430282' itemid, 'Epic  Wine Gift back Sheer Green' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718021565' itemid, 'True Wine Charms' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718039720' itemid, 'True Flume 10 ct' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757411250' itemid, 'Epic Wine Bottle Tags' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757422003' itemid, 'Floating Candle' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757821004' itemid, 'Epic Stem Glass Slippers' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757436284' itemid, 'Epic wine Bottle Gift tags' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '886245003019' itemid, 'Final Touch Wine Traveller' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '741360387737' itemid, 'S''well Insulated water bottle' ItemDescription, 35.99 supplyPrice, 35.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '04913207' itemid, 'Sprite 12oz' ItemDescription, 1.0 supplyPrice, 1.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '012000171277' itemid, 'Bubly Grapefruit 12oz' ItemDescription, 1.0 supplyPrice, 1.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '856036001098' itemid, 'Underwood The Bubbles' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '018200250149' itemid, 'Lime-A-Rita 25oz' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '01241000' itemid, 'Starbucks Frappuccino Vanilla' ItemDescription, 2.75 supplyPrice, 2.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'SODA' Class, '070847811169' itemid, 'Monster Energy Drink 16oz' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '635985132196' itemid, 'Mikes Harder Strawberry' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718021633' itemid, 'True Wine Charm Clings 12 ct' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757830945' itemid, 'Wine Accessories Glass Stick''ems' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '728987012792' itemid, 'Fred Wine Lines, Sturdy' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '786309131354' itemid, 'Heavy Weights Beer Bag' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '739048123746' itemid, 'Googly Eyes Drink Markers' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '698617500398' itemid, 'Wine Botle Pepper Grinder' ItemDescription, 18.99 supplyPrice, 18.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '041498294496' itemid, 'Crofton Cocktail Shaker set' ItemDescription, 13.98 supplyPrice, 13.98 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '077757912405' itemid, 'Bota Bag' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '085455216305' itemid, 'Travel Bottle' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '041498328450' itemid, 'Crofton Flatware Caddy' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277208804' itemid, 'Home Store Kitchen Towel' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '793573145239' itemid, 'Brady Vineyards Petite Sirah' ItemDescription, 23.99 supplyPrice, 23.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '669576018682' itemid, 'Paraduxx Red Wine' ItemDescription, 44.99 supplyPrice, 44.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '669576040003' itemid, 'Canvasback Cabernet Sauvignon' ItemDescription, 36.99 supplyPrice, 36.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '098709010543' itemid, 'Giuseppe Cortese' ItemDescription, 29.99 supplyPrice, 29.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '8034013470064' itemid, 'Le Monde' ItemDescription, 19.99 supplyPrice, 19.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '049331010968' itemid, 'La Crema Monterey Pinot Noir' ItemDescription, 15.0 supplyPrice, 22.99 Price, 'GLAZERS OF IOWA' supplierId UNION 
SELECT 'WINE' Class, '865776000070' itemid, 'Elouan Pinot Noir' ItemDescription, 22.99 supplyPrice, 22.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '857488005542' itemid, 'Bellula Rose' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '852393005298' itemid, 'French Blue Bordeaux Rose' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '857488005535' itemid, 'Chateaumar Cotes-Du-Rhone' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '721059047500' itemid, 'Campari' ItemDescription, 30.99 supplyPrice, 30.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '721059001311' itemid, 'Aperol' ItemDescription, 26.99 supplyPrice, 26.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '080432106624' itemid, 'Becherovka Herbal Liqueur' ItemDescription, 25.99 supplyPrice, 25.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'LIQUOR' Class, '082000781752' itemid, 'The Whisky Enthusiast' ItemDescription, 44.99 supplyPrice, 44.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '084692483907' itemid, 'Brunello Di Montalcino' ItemDescription, 49.99 supplyPrice, 49.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498132439' itemid, 'Minced Garlic' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '00963398' itemid, 'Corn pasta' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '078742003474' itemid, 'Daily Chef Spacghetti' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '035342240241' itemid, 'Italiano Dip' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498286217' itemid, 'Butter Popcorn Seasoning' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498212131' itemid, 'Crinkle Cut Ribbon Noodles' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '035900171062' itemid, 'Sanders Extra Dark Hot Fundge' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '035900171307' itemid, 'Sanders Extra Dark Hot Fundge' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '042456058037' itemid, 'Pirouline Dark Chocolate' ItemDescription, 1.25 supplyPrice, 3.5 Price, 'NONE' supplierId UNION 
SELECT 'SERVICE' Class, 'LEGENDS SHOW 6/1' itemid, 'Legends Show 6/1' ItemDescription, 15.0 supplyPrice, 15.53 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, '11' itemid, 'Cheese House' ItemDescription, 8.49 supplyPrice, 8.49 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, '222' itemid, 'Olives' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '723830000094' itemid, 'Lagunitas IPA' ItemDescription, 7.25 supplyPrice, 10.99 Price, 'I-BEV' supplierId UNION 
SELECT 'FOOD' Class, '042456000135' itemid, 'Pirouline Stawberry' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498115029' itemid, 'Berry Hill Raspberry Spread' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498136093' itemid, 'Fusia Sesame Teriyaki' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '711381000663' itemid, 'Stonewall Strawberry Jam' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498283834' itemid, 'Fusia Hoisin' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '878326002011' itemid, 'LandOLakes Cocoa' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '878326002059' itemid, 'LandOLakes Cocoa French Vanilla' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '878326002073' itemid, 'LandOLakes Arctic White' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '639277780515' itemid, 'Tea, Apple Spice' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '639277300904' itemid, 'Pasta & Pizza Seasoning' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498266745' itemid, 'Clancy''s Pretzel' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '032063104012' itemid, 'Tony Packo''s Pickles & Peppers' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '781138710176' itemid, 'On the Border Chips' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498242169' itemid, 'Korma Curry Sauce' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498242152' itemid, 'Tikka Masala' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498229429' itemid, 'Tikka Masala' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498229443' itemid, 'Jalfrezi Simmer Sauce' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '01660433' itemid, 'Rose Sweetend Lime Juice' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '009542035501' itemid, 'Lindor 8.8oz Chocolate' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '072799054687' itemid, 'Fine Truffles, Milk Chocolate' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '009542015855' itemid, 'Lindor Milk Chocolate' ItemDescription, 1.25 supplyPrice, 1.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '072799056728' itemid, 'Moser Roth Milk Caramel 5oz' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, 'X000B9QP69' itemid, 'Procelain Cheese Buttons' ItemDescription, 14.99 supplyPrice, 14.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '661371903729' itemid, 'Bamboo Cocktail picks 75ct' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '078742146515' itemid, 'Artichoke Hearts, Whole' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '067742760012' itemid, 'Joie Cheese Knife' ItemDescription, 5.99 supplyPrice, 5.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '063362250032' itemid, 'ppd Cheese Knives' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '630613033036' itemid, 'Cheese Knife, Alligator' ItemDescription, 1.0 supplyPrice, 1.0 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '028588701720' itemid, 'Bamboo Cheese Knife' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285006617' itemid, 'Amana Dill Mustard' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '073214004034' itemid, 'Capers' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '071828001012' itemid, 'Horeradish, Extra Hot' ItemDescription, 2.75 supplyPrice, 2.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277628954' itemid, 'Foam Plane' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277483867' itemid, 'Emoticon' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '699284101567' itemid, 'Funny Faces Sticker Book' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '017276229998' itemid, 'Band-aids 20ct' ItemDescription, 1.89 supplyPrice, 1.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '017276230963' itemid, 'Band-aids 20ct' ItemDescription, 1.89 supplyPrice, 1.89 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277578648' itemid, 'Lap Leaders' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277373946' itemid, 'Fairy Doll' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '6932373166035' itemid, 'Glo 6" Light Stick' ItemDescription, 1.79 supplyPrice, 1.79 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277756350' itemid, 'Glow in the Dark Latern' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277057167' itemid, 'Glow Play, Blue' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277057273' itemid, 'Glow Play, variety' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '085761196018' itemid, 'Glow Squigglets' ItemDescription, 2.69 supplyPrice, 2.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277057181' itemid, 'Glow Play, Pink' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277057228' itemid, 'Glow Play, Purple' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '639277304261' itemid, 'Glow wand, Avengers' ItemDescription, 1.99 supplyPrice, 1.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '082676110610' itemid, 'Glow Bars' ItemDescription, 1.69 supplyPrice, 1.69 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '037102644887' itemid, 'Mushrooms, Marinated' ItemDescription, 11.99 supplyPrice, 11.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, 'TURTLE' itemid, 'Brandy turtle' ItemDescription, 39.99 supplyPrice, 39.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498266394' itemid, 'Onion Chutney' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070759127129' itemid, 'Brussels Sprouts, Pickled' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '021285553111' itemid, 'Amana Pepper Relish' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '813293026066' itemid, 'Wine Glass, Breakfast' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'BEER' Class, '813293024048' itemid, 'Wine Glass, Therapy' ItemDescription, 2.99 supplyPrice, 2.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '855150002011' itemid, 'Asparagus, Pickled' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '073214006168' itemid, 'Jalapeno Stuffed Olives' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498143336' itemid, 'Olives, Garlic Stuffed' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '070759126122' itemid, 'Green Beans, Pickled' ItemDescription, 8.99 supplyPrice, 8.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '405000009662' itemid, 'Napa Valley Grape seed oil' ItemDescription, 13.99 supplyPrice, 13.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '00978927' itemid, 'Glaze, Balsamic' ItemDescription, 6.99 supplyPrice, 6.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498248901' itemid, 'Stonemill Bread Dipping' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '713035142637' itemid, 'Spicy Red Picante' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '041498221454' itemid, 'Glaze, Balsamic Vinegar' ItemDescription, 3.5 supplyPrice, 6.99 Price, 'ALDIS' supplierId UNION 
SELECT 'FOOD' Class, '071072011294' itemid, 'Aceto Balsamico' ItemDescription, 4.99 supplyPrice, 4.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '851609006012' itemid, 'White Wine Vinegar' ItemDescription, 3.99 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '609503707012' itemid, 'Donostia Extra Virgin Olive Oil' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '876718005176' itemid, 'True Foil cutter corkscrew, Black' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '041116011320' itemid, 'Ringpop' ItemDescription, 0.25 supplyPrice, 0.75 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '8018154004296' itemid, 'Ranieri Grape Seed Oil' ItemDescription, 9.99 supplyPrice, 9.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'GIFT' Class, '797307151602' itemid, 'Wine Journal (Purple)' ItemDescription, 2.0 supplyPrice, 3.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'SNACK, SODA, & CANDY' Class, '028400055116' itemid, 'Lay''s Cheddar Stax' ItemDescription, 1.25 supplyPrice, 2.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'MIXERS' Class, '038000188657' itemid, 'Pringles BBQ' ItemDescription, 1.25 supplyPrice, 2.25 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, 'CAVE AGED CHEDDAR' itemid, 'Cave Aged Cheddar' ItemDescription, 7.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100063387' itemid, 'Vintage English Cheddar' ItemDescription, 3.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'FOOD' Class, '4099100037296' itemid, 'Rustic Red Cheddar' ItemDescription, 3.99 supplyPrice, 8.99 Price, 'ALDIS' supplierId UNION 
SELECT 'FOOD' Class, '4099100037319' itemid, 'Cave Aged Cheddar' ItemDescription, 3.99 supplyPrice, 7.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'PROPANE' Class, 'PROPANE EXCHANGE' itemid, 'Propane' ItemDescription, 15.99 supplyPrice, 15.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'WINE' Class, '5435435435' itemid, 'Generic wine' ItemDescription, 10.99 supplyPrice, 10.99 Price, 'FRESHIES' supplierId UNION 
SELECT 'CUSTOM' Class, 'STUFFED BEAR' itemid, 'bear' ItemDescription, 10.0 supplyPrice, 10.0 Price, 'none' supplierId
) a
) b
ON s.name = b.supplierId