import tkinter as tk
from soluciones_visual import ochoReinasVisual

class menuOchoReinas:
    
    def __init__(self, root):
        self.root = root
        self.root.title("Ocho Reinas : Menu")
        self.root.geometry("400x300") #res
        
        # Boton jugar
        play_button = tk.Button(
            self.root, text = "Jugar", command = self.open_game_window
        )
        play_button.pack(pady = 10)
        
        # Boton soluciones
        sol_button = tk.Button(
            self.root, text = "Soluciones Ocho Reinas", command = self.open_solution_window
        )
        sol_button.pack(pady = 20)
        
    def open_game_window(self):
        game_window = tk.Toplevel(self.root)
        game_window.title("Ocho Reinas : Juego")
        game_window.geometry("500x500")
        
        
        
        close_button = tk.Button(
            game_window, text = "Cerrar ventana", command = game_window.destroy
        )
        close_button.pack(pady = 20)
        
    def open_solution_window(self):
        solution_window = tk.Toplevel(self.root)
        app_soluciones = ochoReinasVisual(solution_window)
    
        
if __name__ == "__main__":
    root = tk.Tk()
    app = menuOchoReinas(root)
    root.mainloop()