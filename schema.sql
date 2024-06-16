CREATE TABLE objeto (
    id BIGSERIAL PRIMARY KEY,
    nombre TEXT NOT NULL,
    descripcion TEXT NOT NULL,
    precio DOUBLE PRECISION NOT NULL,
    fecha_creacion TIMESTAMPTZ NOT NULL
);
