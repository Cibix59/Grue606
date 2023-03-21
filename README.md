# Grue606

Commandes :
A/E : Rotation du mat
R/F : Monter/Descendre crochet
LeftShift : Declencher les supports
Fleches directives : deplacer la grue
W/X : Lever/Baisser le bras
E/D : Avancer/Retracter le bras


Choix :
	- Pour la gestion des supports je fixe simplement le target à une valeur fixe en fonction d'un Bool
	- Pour la gestion de la rotation du mat et celle du crochet, j'ai repris le code deja existant en l'adaptant aux articulations, j'ai un peu de mal à trouver le stiffness et deamping correct pour le crochet
	
	
Problemes connus : 
	- Il faudrait desactiver le deplacement lorsque les supports sont en position
	- Pour actionner les supports j'ai tout mis dans un seul script se trouvant dans leur racine commune, il vaudrait mieux faire un script par support avec des variables pour les targets, comme je ne maitrise pas assez j'ai préféré tout mettre au meme endroit au prix d'une grosse redondance dans le code
  	- Je n'utilise pas les input settings car j'ai eu des problemes avec, la detection du leftShift se fait dans une boucle FixedUpdate et a donc tendance à se remettre à spammer
	
