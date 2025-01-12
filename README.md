Përshkrimi i Arkitekturës Onion
Arkitektura Onion është një model i organizimit të kodit që ndihmon në ndarjen e përgjegjësive në shtresa të ndryshme, duke minimizuar varësitë midis moduleve dhe duke promovuar testueshmëri dhe mirëmbajtje. Shtresat janë të ndara si më poshtë:

1. 01_Web (Shtresa e Prezantimit)
Roli: Kjo shtresë është përgjegjëse për ndërfaqen e përdoruesit dhe për përpunimin e kërkesave që vijnë nga përdoruesit. Përmban:

Controllers: Përfshijnë HomeController.cs dhe WeddingController.cs, të cilat merren me kërkesat HTTP dhe drejtojnë logjikën në shërbime përkatëse.
Views: Dosja Pages përmban Index.cshtml, ku paraqiten të dhënat në nivel UI (User Interface).
wwwroot: Përmban burimet statike, si CSS, JavaScript, dhe imazhe.
appsettings.json: Ky file ruan konfigurimet për aplikacionin, si lidhjet me bazën e të dhënave dhe konfigurimet e tjera të përgjithshme.
2. 02_Domain (Shtresa e Domainit)
Roli: Kjo është shtresa më e brendshme dhe përmban entitetet bazë të domenit dhe logjikën biznesore thelbësore. Kjo shtresë nuk ka varësi nga pjesët e tjera të sistemit. Disa shembuj të entiteteve në këtë projekt janë:

MainApp: Përcakton informacionin bazik të aplikacionit.
Wedding, Client, Services, VenueDecoration, Photography: Janë entitete që modelojnë domenin e menaxhimit të dasmave.
User dhe Staff: Përfaqësojnë përdoruesit dhe stafin në sistem.
3. 03_Service (Shtresa e Shërbimeve)
Roli: Përmban logjikën e biznesit që shërben si ndërmjetës midis shtresës së prezantimit dhe shtresës së të dhënave. Kjo shtresë përfshin:

Shërbimet (Services): Këtu implementohen operacionet që përpunojnë të dhënat dhe i dërgojnë ato në shtresën Web.
4. 04_Persistent (Shtresa e Qasjes në të Dhëna)
Roli: Përgjegjëse për ruajtjen dhe qasjen në të dhëna. Kjo shtresë përmban:

WeddingEventManagmentDbContext.cs: Është klasa e kontekstit që përdor EF Core për të lidhur aplikacionin me bazën e të dhënave. Kjo klasë përfshin DbSet për çdo entitet në domen.
Repository (nëse është implementuar): Kjo mund të përdoret për të ofruar një mënyrë të organizuar për qasjen në të dhënat e domenit.
Varësitë midis Shtresave
Shtresa Web varet nga Service për logjikën e biznesit.
Shtresa Service varet nga Persistent për qasje në të dhëna dhe nga Domain për modelet bazë të domenit.
Shtresa Domain është e izoluar dhe nuk ka varësi nga shtresat e tjera, duke siguruar modularitetin e sistemit.
Përparësitë e Kësaj Arkitekture
Modulariteti: Secila shtresë është e pavarur dhe mund të zhvillohet, testohet, dhe zëvendësohet pa ndikuar në të tjerat.
Testueshmëri: Kjo ndarje e qartë e shtresave ndihmon në krijimin e testeve të njësisë për çdo komponent.
Mirëmbajtja: Struktura e organizuar e bën më të lehtë mirëmbajtjen dhe zgjerimin e projektit.
