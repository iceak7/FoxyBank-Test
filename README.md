# FoxyBank-Test

Vad som kan få få fel:

### Insättning av pengar
- Användaren lyckas sätta in en negativ summa pengar och det påverkar saldot
- Användarens saldo blir felaktigt efter insättningen

### Subtraktion av saldo
- Användaren subtraherar ett negativt tal och får ett ökat saldo
- Det subtraheras mer pengar än kontot har på ett konto som inte är ett lånekonto.
- Saldot blir felaktigt.

### Autentisering
- Autentiseringen ska misslyckas men lyckas 
- Autentiseringen ska lyckas men misslyckas


