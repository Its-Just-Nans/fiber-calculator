# translate by AI

import math

# Input values
E = float(input("EMETTEUR="))
R = float(input("RECEPT="))
A = float(input("AttenuationFibre="))
M = float(input("LongueurFibre="))
F = float(input("Fibre-Fibre="))
I = float(input("Emetteur-Fibre="))
G = float(input("Fibre-Recept="))

# Calculate total power
T = 10 * math.log10(E / R)
print(f"TOTAL={T}")

# Calculate attenuation by fiber link
A *= M / 1000
print(f"attenuation par lien={A}")

# Calculate remaining power
Y = T - (I + A + G)

# Calculate the number of times to take the integer part
O = int(Y / (A + F))
print(f"Nombre entier à prendre={O}")

# Calculate the remaining power after taking the integer part
V = T - (I + A + G) - ((A + F) * O)
print(f"{I}+{A}+{O}*{A+F}+X+{G}={round(T, 3)}")
print(f"Nombre restant={V}")

P = 0

# Check if there's enough power for additional fiber
if (V - F) > 0:
    P = ((V - F) * M) / A
    print(f"metres de fibre en plus ={P}")
else:
    print("Nombre restant trop petit")

# Calculate the total length of fiber
L = M + O * M + P
print(f"Longueur totale={L}")

# Calculate the dispersion parameters
L /= 1000
Y = float(input("INDICE Y="))
R = float(input("BANDE INTRA B0="))
K = R / (L ** Y)
print(f"BANDE MODAL={K}")

S = 1 / (2 * K)
print(f"TM={S} EN US")
S *= 1000
print(f"{S} EN NS")

# Calculate dispersion coefficient
Z = float(input("DC="))
J = float(input("GAMMA=")) / 10
Z *= J * L
print(f"TC={Z} ps")
Z /= 1000
print(f"{Z} ns")

# Calculate total dispersion
W = math.sqrt(S ** 2 + Z ** 2)
print(f"TTOT={W} ns")

# Calculate bandwidth
N = 1 / (2 * W)
N *= 1000
print(f"BANDE PASSANTE={N} MHz")
