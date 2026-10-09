import tkinter as tk
from ochoreinas_logica import ochoReinas


class ochoReinasVisual(tk.Toplevel):

    def __init__(self, menu):
        super().__init__(menu)
        self.title("Tablero de Ajedrez - 8 Reinas")

        self.juego = ochoReinas()
        self.soluciones = self.juego.calcularSoluciones()
        self.indiceSol = 0

        self.tam_casilla = 60  # Tamaño en píxeles
        self.N = self.juego.N  # Tablero N x N

        # CONTROLES
        frame_controles = tk.Frame(self, pady=10)
        frame_controles.pack()

        self.btn_ant = tk.Button(
            frame_controles, text="<- Anterior", command=self.anterior
        )
        self.btn_ant.pack(side=tk.LEFT, padx=5)

        self.lbl_info = tk.Label(
            frame_controles, text="", font=("Arial", 11, "bold"), width=20
        )
        self.lbl_info.pack(side=tk.LEFT, padx=5)

        self.btn_sig = tk.Button(
            frame_controles, text="Siguiente ->", command=self.siguiente
        )
        self.btn_sig.pack(side=tk.LEFT, padx=5)

        # CANVAS DEL TABLERO
        self.canvas = tk.Canvas(
            self,
            width=self.tam_casilla * self.N,
            height=self.tam_casilla * self.N,
        )
        self.canvas.pack(
            pady=10, padx=10
        )  # pad es el espaciado exterior en X y Y
        
        self.update_idletasks()
    
        self.mostrar_solucion()

    def dibujar_tablero(self):
        self.canvas.delete("all")
        c_blanco = "#F0D9B5"  # Tono madera claro para mayor estética
        c_negro = "#B58863"  # Tono madera oscuro

        for fila in range(self.N):
            for col in range(self.N):
                # Asignar dimensiones
                x1 = col * self.tam_casilla
                y1 = fila * self.tam_casilla
                x2 = x1 + self.tam_casilla
                y2 = y1 + self.tam_casilla

                color = c_blanco if (fila + col) % 2 == 0 else c_negro
                self.canvas.create_rectangle(
                    x1, y1, x2, y2, fill=color, outline=""
                )



    def dibujar_reinas(self, tablero_actual):
        # Corrección: iterar sobre 'tablero_actual' en vez de 'self.tablero'
        for fila, col in enumerate(tablero_actual):
            if col != -1:  # Si la reina está posicionada en esa fila
                # Poner en el centro de la casilla
                x = col * self.tam_casilla + (self.tam_casilla // 2)
                y = fila * self.tam_casilla + (self.tam_casilla // 2)

                # Dibujar reina con buen contraste
                self.canvas.create_text(
                    x, y, text="♛", font=("Arial", 32), fill="#222222"
                )

    def mostrar_solucion(self):
        self.dibujar_tablero()
        if not self.soluciones:
            self.lbl_info.config(text="Sin soluciones")
            return

        solucion_actual = self.soluciones[self.indiceSol]
        self.dibujar_reinas(solucion_actual)

        # Corrección: agrupar (self.indiceSol + 1) y mostrar total de soluciones
        total = len(self.soluciones)
        self.lbl_info.config(
            text=f"Solución {self.indiceSol + 1} de {total}"
        )

    def siguiente(self):
        if self.soluciones:
            self.indiceSol = (self.indiceSol + 1) % len(self.soluciones)
            self.mostrar_solucion()

    def anterior(self):
        if self.soluciones:
            self.indiceSol = (self.indiceSol - 1) % len(self.soluciones)
            self.mostrar_solucion()
