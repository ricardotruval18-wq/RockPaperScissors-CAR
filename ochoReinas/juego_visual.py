import tkinter as tk
from ochoreinas_logica import ochoReinas


class juegoVisual(tk.Toplevel):

    def __init__(self, root):
        super().__init__(root)
        self.title("Ocho Reinas : Juego")

        self.juego = ochoReinas()
        self.tablero_usuario = [-1] * self.juego.N
        self.tam_casilla = 60
        self.N = self.juego.N

        self.lbl_info = tk.Label(
            self,
            text="Haz click donde quieras colocar la reina",
            font=("Arial", 10)
        )
        self.lbl_info.pack(pady=10)

        # crear canvas
        self.canvas = tk.Canvas(
            self,
            width=self.tam_casilla * self.N,
            height=self.tam_casilla * self.N,
            bg="#FBF8F8",
        )
        self.canvas.pack(pady=0, padx=10)

        self.canvas.bind("<Button-1>", self.manejar_click)

        frame_botones = tk.Frame(self, pady=10)
        frame_botones.pack()

        # botones
        self.btn_comprobar = tk.Button(
            frame_botones,
            text="Comprobar solucion",
            font=("Arial", 10, "bold"),
            bg="#999999",
            command=self.comprobar
        )
        self.btn_comprobar.pack(side=tk.LEFT, padx=5)

        self.btn_reiniciar = tk.Button(
            frame_botones,
            text="Reiniciar tablero",
            font=("Arial", 10),
            command=self.reiniciar
        )
        self.btn_reiniciar.pack(side=tk.LEFT, padx=5)

        self.update_idletasks()
        self.dibujar_tablero()

    def dibujar_tablero(self):
        self.canvas.delete("all")
        c_blanco = "#F0F0F0"
        c_negro = "#D27FCB"

        for fila in range(self.N):
            for col in range(self.N):
                x1 = col * self.tam_casilla
                y1 = fila * self.tam_casilla
                x2 = x1 + self.tam_casilla
                y2 = y1 + self.tam_casilla
                
                color=c_blanco if (fila+col)%2 == 0 else c_negro
                
                self.canvas.create_rectangle(
                    x1, y1, x2, y2, fill= color, outline=""
                )

        for fila, col in enumerate(self.tablero_usuario):
            if col != -1:
                x = col * self.tam_casilla + (self.tam_casilla // 2)
                y = fila * self.tam_casilla + (self.tam_casilla // 2)

                self.canvas.create_text(
                    x, y, text="♛", font=("Arial", 32), fill="#222222"
                )

    def manejar_click(self, event):
        col = event.x // self.tam_casilla
        fila = event.y // self.tam_casilla

        if 0 <= fila < self.N and 0 <= col < self.N:
            if self.tablero_usuario[fila] == col:
                self.tablero_usuario[fila] = -1
            else:
                self.tablero_usuario[fila] = col
            self.dibujar_tablero()

    def comprobar(self):
        # Validar si faltan reinas por colocar (cada fila debe tener una)
        if -1 in self.tablero_usuario:
            self.lbl_info.config(
                text="Faltan reinas por colocar (una por fila).", fg="#D9534F"
            )
            return

        # Comprobar contra las soluciones válidas usando la lógica
        es_valida = self.juego.compararSoluciones(self.tablero_usuario)
        if es_valida:
            self.lbl_info.config(
                text="¡Felicidades! Es una solución correcta.", fg="#5CB85C"
            )
        else:
            self.lbl_info.config(
                text="Incorrecto: Las reinas se atacan en alguna diagonal/columna.",
                fg="#D9534F",
            )

    def reiniciar(self):
        self.tablero_usuario = [-1] * self.N
        self.lbl_info.config(
            text="Tablero reiniciado", fg="black"
        )
        self.dibujar_tablero()