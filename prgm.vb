Disp "Saisir"
Disp "emetteur"
Disp "en MILLIWATTS"
Input "EMETTEUR=",E

Disp "Saisir"
Disp "recepteur"
Disp "en MILLIWATTS"
Input "RECEPT=",R

10log(E/R)→T
Disp "TOTAL=",T

Disp "Saisir"
Disp "attenuation fibre"
Disp "sur 1000 mètres"
Disp "en dB"
Input "AttenuationFibre=",A

Disp "Saisir"
Disp "longeur fibre"
Disp "en metres"
Input "LongueurFibre=",M

A*M/1000→A
Disp "attenuation par lien"+versChaîne(A)

Disp "Saisir"
Disp "jonction fibre-fibre"
Disp "en dB"
Input "Fibre-Fibre=",F

Disp "Saisir"
Disp "jonction emetteur-fibre"
Disp "en dB"
Input "Emetteur-Fibre=",I

Disp "Saisir"
Disp "jonction fibre-recepteur"
Disp "en dB"
Input "Fibre-Recept=",G

T-(I+A+G)→Y

Y/(A+F)→O
Disp "Nombre entier à prendre=",O
Disp "Donc ",ent(O)

ent(O)→O

T-(I+A+G)-((A+F)*O)→V
Disp versChaîne(I)+"+"+versChaîne(A)+"+"+versChaîne(O)+"*"+versChaîne(A+F)+"+X+"+versChaîne(G)+"="+versChaîne(arrondir(T,3))
Disp "Nombre restant=",V
Pause 
0→P
If (V-F)>0
Then
(((V-F)*M)/A)→P
Disp "metres de fibre en plus =",P
Else
Disp "Nombre restant trop petit"
0→P
End
M+O*M+P→L
Disp "Longueur totale=",L
Pause 
L/1000→L
Input "INDICE Y=",Y
Disp "EN MHZ.KM"
Input "BANDE INTRA B0=",R
R/(L^Y)→K
Disp "BANDE MODAL="
Disp K
Disp "DONC DISPERSION MODAL="
1/(2*K)→S
Disp "TM="
Disp S
Disp "EN US"
S*1000→S
Disp S
Disp "EN NS"
Pause 
Disp "COEF DISPERSION"
Disp "EN PS/(NM*KM)"
Input "DC=",Z
Disp "LARGEUR SPECTRALE EN A"
Disp "10A=1NM"
Input "GAMMA=",J
J/10→J
Z*J*L→I
Disp "TC="
Disp I
Disp "EN PS"
I/1000→I
Disp I
Disp "EN NS"
Pause 
√((S^2)+(I^2))→W
Disp "TTOT="
Disp W
Disp "EN NS"
1/(2*W)→N
N*1000→N
Disp "BANDE PASSANTE"
Disp N
Disp "EN MHZ"
