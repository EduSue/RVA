#include <iostream>
#include <string>
#include <vector>

class Usuario {
private:
    int id;
    std::string nombre;
    std::string usuario;

public:
    Usuario(int id, const std::string& nombre, const std::string& usuario)
        : id(id), nombre(nombre), usuario(usuario) {}

    int getId()  
    { 
        return id; 
    }
    std::string getNombre() 
    { 
        return nombre; 
    }
    std::string getUsuario()  
    { 
        return usuario; 
    }

    void setNombre(const std::string& nombre) 
    { 
        this->nombre = nombre; 
    }
    void setUsuario(const std::string& usuario) 
    { 
        this->usuario = usuario; 
    }

    void mostrarInfo() const {
        std::cout << "ID: " << id << ", Nombre: " << nombre << ", Usuario: " << usuario << std::endl;
    }
};

int main() {
    std::vector<Usuario> usuarios;

    usuarios.emplace_back(1, "Alice", "alice123");
    usuarios.emplace_back(2, "Bob", "bob456");

    for (const auto& usuario : usuarios) {
        usuario.mostrarInfo();
    }

    usuarios[0].setNombre("Alicia");
    usuarios[0].setUsuario("alicia123");

    std::cout << "Informacion actualizada de usuarios:\n";
    for (const auto& usuario : usuarios) {
        usuario.mostrarInfo();
    }

    return 0;
}
