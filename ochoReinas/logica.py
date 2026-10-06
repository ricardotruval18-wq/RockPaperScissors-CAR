#TODO 
# import stuff
# create logic
# make visuals
# finish
class ochoReinas:
    def __init__(self, size = 8):
        self.N = size
        self.tablero = [-1] * self.N
        self.soluciones = []
        
    def es_seguro(self, tablero, fila, col):
        for f_anterior in range(fila):
            c_anterior = tablero[f_anterior]
            # comprobaciones
            #1. MISMA COL
            if c_anterior == col:
                return False
            #2. Diagonal
            if abs(f_anterior - fila) == abs(c_anterior - col):
                return False
        return True #Si no se cumplen los otros casos entonces es seguro
    
    # funcion backtracking
    def resolver(self, tablero, fila, soluciones):
        if fila == self.N:    # caso base
            self.soluciones.append(list(tablero))
            return
        
        for col in range(self.N):
            if self.es_seguro(tablero, fila, col):
                tablero[fila] = col
                self.resolver(tablero, fila + 1, soluciones)
                tablero[fila] = -1    
                
    def calcularSoluciones(self):
        self.soluciones = []
        self.tablero = [-1] * self.N
        self.resolver(self.tablero, 0, self.soluciones)
        return self.soluciones
    
juego = ochoReinas
soluciones = juego.calcularSoluciones()
       
print(f"Total de soluciones : {len(soluciones)}")
for solucion in soluciones:
    print(solucion)