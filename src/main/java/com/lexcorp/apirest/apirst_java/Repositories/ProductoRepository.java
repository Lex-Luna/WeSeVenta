package com.lexcorp.apirest.apirst_java.Repositories;

import com.lexcorp.apirest.apirst_java.Entities.Producto;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProductoRepository extends JpaRepository<Producto, Long> {
}
