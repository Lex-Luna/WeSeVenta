package com.lexcorp.apirest.apirst_java.Controllers;

import com.lexcorp.apirest.apirst_java.Entities.Producto;
import com.lexcorp.apirest.apirst_java.Repositories.ProductoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/productos")
public class ProductoController {

    @Autowired
    private ProductoRepository productoRepository;
    @GetMapping
    public List<Producto> findAllProducto() {
        return productoRepository.findAll();
    }

    @PostMapping
    public Producto createProducto(@RequestBody Producto producto) {
        return productoRepository.save(producto);
    }
    @GetMapping("/{id}")
    public Producto findByIdProductoXid(@PathVariable Long id) {
        return productoRepository.findById(id).orElseThrow (()-> new RuntimeException("Producto no encontrado"+ id));
    }
    @PutMapping("/{id}")
    public Producto updateProducto(@RequestBody Producto producto, @PathVariable Long id) {
        producto.setId(id); // ← ESTO ES OBLIGATORIO
        return productoRepository.save(producto);
    }
    @DeleteMapping("/{id}")

    public String deleteProducto(@PathVariable Long id) {
        productoRepository.deleteById(id);
        return "El producto con el id"+ id +" fue eliminado";
    }
}
