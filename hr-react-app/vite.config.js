import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import tailwindcss from '@tailwindcss/vite'

// https://vite.dev/config/
export default defineConfig({
  plugins: [react(), tailwindcss()],
  server: {
    host: '0.0.0.0',
    
    proxy: {
      '/api': {
        target: 'https://localhost:7293/api',
        changeOrigin: true,
        secure: false,
      },
    },
  },
})
