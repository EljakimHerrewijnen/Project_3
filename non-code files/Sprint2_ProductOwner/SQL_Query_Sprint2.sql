/* What is the relative satisfaction with living in each district of Rotterdam?*/
/*Select Wijk, AVG(Data)
From tevredenheid_met_het_wonen_in_de_buurt_;*/

/* Which district has relatively most nuisance of youth groups? 
Select Wijk, Max(Data)
From buurtprobleem_vervuiling_op_straat
Group By Wijk */

/*Which district has relatively most nuisance of youth groups? 
Select Wijk, Max(Data)
From buurtprobleem_overlast_van_groepen_jongeren
Group By Wijk;*/

/*How many percent of the population in each district is victim of housebreaking?
Select *
From buurtprobleem_woninginbraak*/

/*	In which district take the least amount of violent crimes place?
Select *
From slachtofferschap_bedreiging_met_geweld, slachtofferschap_tasjesroof_met_geweld
/* 

/*	In which district are relatively the least victims of mistreatment?
Select *
From slachtofferschap_mishandeling;

/*	To which district should I go to have the least risk of car theft?
Select *
From slachtofferschap_autodiefstal;*/

/*To which district should I go to have the least risk of bycicle theft?
Select *
From fietsen_diefstal*/

/*Which district has relatively the most report of menace?
Select Wijk, Max(Data)
From buurtprobleem_drugsoverlast
=================
Note: Since we are using a heat map, there is no real advantage of selecting the least or the max. This can still be added though. */