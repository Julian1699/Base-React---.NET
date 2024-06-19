# Usa una imagen base de Node.js
FROM node:16-alpine AS build
WORKDIR /app

# Copia los archivos package.json y package-lock.json e instala las dependencias
COPY package*.json ./
RUN npm install

# Copia el resto de los archivos y construye la aplicación
COPY . ./
RUN npm run build

# Usa una imagen base de nginx para servir la aplicación
FROM nginx:alpine
COPY --from=build /app/build /usr/share/nginx/html

# Expone el puerto en el que nginx estará escuchando
EXPOSE 80

# Comando por defecto para ejecutar nginx
CMD ["nginx", "-g", "daemon off;"]
