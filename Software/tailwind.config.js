/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ['./Views/**/*.cshtml', './Pages/**/*.cshtml'],
  theme: {
      extend: {
          colors: {
              "Jaguar": "#1F1E30",
              "Cultured": "#F7F7F5",
              "White": "#FFF",
              "Buster": "#D8F275",
              "Bud": "#EDF8C3",
              "Gray": "#76767F",
              "Lavender":"#DEDEF7"
          }
      },
  },
  plugins: [],
}

