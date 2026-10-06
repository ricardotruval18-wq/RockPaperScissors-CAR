import tkinter as tk
from logica import ochoReinas

class ochoReinasVisual:
    def __init__(self, root):
        root = tk.Tk()
        root.title("Tablero de Ajedrez")
        
        self.juego = ochoReinas
        self.soluciones = self.juego.calcularSoluciones
        self.indiceSolucion = 0
        
        self.tam_casilla = 60 #asignar el tam a 60 pixeles
        self.N = self.juego.N # Tablero 8*8
        
        #CONTROLES
        frame_controles = tk.Frame(self.root, py = 10)
        frame_controles.pack()
        
        self.btn_ant = tk.Button(
            frame_controles, text = "<- Anterior", command = self.anterior
        )
        self.btn_ant.pack(side=tk.LEFT, padx=5)
        
        self.lbl_info = tk.Label(
            frame_controles, text="", font=("Arial", 11, "bold"), width=20
        )
        self.lbl_info.pack(side=tk.LEFT, padx=5)
        
        self.btn_sig = tk.Button(
            frame_controles, text = "Siguiente ->", command = self.siguiente
        )
        self.btn_sig.pack(side = tk.LEFT, padx=5)
        
        #canvas
        self.canvas = tk.Canvas(root, width = self.tam_casilla * self.N, height = self.tam_casilla * self.N )
        self.canvas.pack(pady = 10, padx = 10)#creo que pad es el espaciado en x y y

        self.mostrar_solucion()
        
        def dibujar_tablero():
            self.canvas.delete("all")
            c_blanco = "#FFFFFF"
            c_negro = "#000000"
            
            for fila in range(self.N):
                for col in range(self.N):
                    #Asignar dimensiones
                    y1 = self.tam_casilla*fila
                    x1 = self.tam_casilla*col
                    y2 = y1 + self.tam_casilla
                    x2 = x1 + self.tam_casilla
                    
                    if((fila+col)%2 == 0):
                        color = c_blanco
                    else:
                        color = c_negro
                    self.canvas.create_rectangle(x1, y1, x2, y2, fill=color, outline = "")
        
        def mostrar_solucion(self):
            self.dibujar_tablero()
            if not self.solucionies:
                return
                 
        def siguiente(self):
            if self.soluciones:
                self.indiceSolucion = (self.indice_sol + 1) % len(self.soluciones)
                self.mostrar_solucion
                
        def anterior(self):
            if self.soluciones:
                self.indice_sol = (self.indice.sol - 1) % len(self.soluciones)
                self.mostrar_solucion()   
        
        def dibujar_reinas():
            for fila, col in enumerate(self.tablero):
                if col != -1: #si no esta vacio
                    #poner en el centro
                    x = col * self.tam_casilla + (self.tam_casilla // 2)
                    y = fila * self.tam_casilla + (self.tam_casilla // 2)
                    
                    #dibujar reina
                    self.canvas.create_text(x,y, text = "♛", font= ("Arial", 32), fill = "#992222")
                    
if __name__ == "__main__":
    root = tk.Tk()
    app = ochoReinasVisual(root)
    root.mainloop()