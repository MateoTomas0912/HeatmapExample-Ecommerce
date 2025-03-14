// Incluir heatmap.js desde CDN
const script = document.createElement("script");
script.src = "https://cdnjs.cloudflare.com/ajax/libs/heatmap.js/2.0.2/heatmap.min.js";
document.head.appendChild(script);

script.onload = () => {
    // Inicializar el heatmap
    const heatmapInstance = h337.create({
        container: document.getElementById('heatmapContainer'),
        radius: 30,
        maxOpacity: 0.6,
        minOpacity: 0.2,
        blur: 0.75
    });

    // Obtener datos del backend
    fetch("https://localhost:7179/api/heatmap") // Reemplazar con tu URL real
        .then(response => response.json())
        .then(data => {
            const formattedData = {
                max: 10,
                data: data.map(event => ({
                    x: event.x, 
                    y: event.y, 
                    value: event.event === "click" ? 10 : 1 // Mayor peso a los clics
                }))
            };
            heatmapInstance.setData(formattedData);
        })
        .catch(error => console.error("Error al obtener datos del heatmap:", error));
};

window.addEventListener('scroll', () => {
    heatmapInstance.repaint();
});
