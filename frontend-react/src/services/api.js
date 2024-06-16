import axios from 'axios';

// Configuración base de Axios
const api = axios.create({
  baseURL: 'http://localhost:5001/api/Objeto',
  headers: {
    'Content-Type': 'application/json',
  },
});

// Funciones para interactuar con la API de objetos
export const getObjetos = async () => {
  try {
    const response = await api.get('/');
    return response.data;
  } catch (error) {
    console.error('Error al obtener objetos', error.response?.data?.message || error.message);
    throw error;
  }
};

export const getObjetoById = async (id) => {
  try {
    const response = await api.get(`/${id}`);
    return response.data;
  } catch (error) {
    console.error(`Error al obtener objeto con id ${id}`, error.response?.data?.message || error.message);
    throw error;
  }
};

export const createObjeto = async (objeto) => {
  try {
    const response = await api.post('/', objeto);
    console.log('Objeto creado con éxito:', response.data.message);
    return response.data;
  } catch (error) {
    console.error('Error al crear objeto', error.response?.data?.message || error.message);
    throw error;
  }
};

export const updateObjeto = async (id, objeto) => {
  try {
    const response = await api.put(`/${id}`, objeto);
    console.log('Objeto actualizado con éxito:', response.data.message);
    return response.data;
  } catch (error) {
    console.error(`Error al actualizar objeto con id ${id}`, error.response?.data?.message || error.message);
    throw error;
  }
};

export const deleteObjeto = async (id) => {
  try {
    const response = await api.delete(`/${id}`);
    console.log('Objeto eliminado con éxito:', response.data.message);
  } catch (error) {
    console.error(`Error al eliminar objeto con id ${id}`, error.response?.data?.message || error.message);
    throw error;
  }
};

export const findByFilters = async (filters) => {
  try {
    const queryParams = new URLSearchParams(filters).toString();
    const response = await api.get(`/buscar?${queryParams}`);
    return response.data;
  } catch (error) {
    console.error('Error al buscar objetos con filtros', error.response?.data?.message || error.message);
    throw error;
  }
};
