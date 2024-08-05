#include <iostream>
#include <string>
#include <vector>

class Puntaje {
private:
    int id;
    std::string nombre;
    int puntaje;

public:
    Puntaje(int id, const std::string& nombre, int puntaje = 0)
        : id(id), nombre(nombre), puntaje(puntaje) {}

    int getId() 
    { 
        return id; 
    }
    std::string getNombre()  
    { 
        return nombre; 
    }
    int getPuntaje() 
    { 
        return puntaje; 
    }

    void setNombre(const std::string& nombre)
    { 
        this->nombre = nombre; 
    }
    void setPuntaje(int puntaje) 
    { 
        this->puntaje = puntaje; 
    }

    void mostrarInfo() const {
        std::cout << "ID: " << id << ", Nombre: " << nombre << ", Puntaje: " << puntaje << std::endl;
    }

    void aumentarPuntaje(int cantidad) {
        puntaje += cantidad;
    }

    void disminuirPuntaje(int cantidad) {
        if (puntaje >= cantidad) {
            puntaje -= cantidad;
        }
        else {
            puntaje = 0;
        }
    }
};

int main() {
    std::vector<Puntaje> jugadores;

    jugadores.emplace_back(1, "Pana", 50);
    jugadores.emplace_back(2, "Bobi");

    for (const auto& jugador : jugadores) {
        jugador.mostrarInfo();
    }

    jugadores[0].aumentarPuntaje(10);

    jugadores[1].disminuirPuntaje(5);

    std::cout << "Informacion actualizada del puntaje:\n";
    for (const auto& jugador : jugadores) {
        jugador.mostrarInfo();
    }

    return 0;
}
