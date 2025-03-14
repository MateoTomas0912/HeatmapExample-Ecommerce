(function () {
    let heatmapData = [];
    const endpoint = "https://localhost:7179/api/heatmap"; // Reemplaza con la URL de tu API

    let lastMousePosition = null;

    // Capturar el movimiento del mouse solo cada 500ms
    setInterval(() => {
        if (lastMousePosition) {
            heatmapData.push({
                x: lastMousePosition.x + window.scrollX, 
                y: lastMousePosition.y + window.scrollY, 
                event: "move",
                timestamp: Date.now()
            });
        }
    }, 200); // Intervalo de 200ms

    // Actualizar la posición del mouse en cada movimiento
    document.addEventListener("mousemove", (event) => {
        lastMousePosition = { x: event.clientX, y: event.clientY };
    });

    // Capturar clics con ajuste de scroll
    document.addEventListener("click", (event) => {
        heatmapData.push({
            x: event.clientX + window.scrollX, 
            y: event.clientY + window.scrollY, 
            event: "click",
            timestamp: Date.now()
        });
    });

    // Enviar los datos a la API cada 3 segundos
    setInterval(() => {
        if (heatmapData.length > 0) {
            fetch(endpoint, {
                method: 'POST', 
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(heatmapData)
            }).then(response => {
                if (!response.ok) {
                    console.error('Error al enviar los datos:', response.status);
                }
            }).catch(error => {
                console.error('Error al enviar la solicitud:', error);
            });

            heatmapData = [];  // Limpiar los datos después de enviarlos
        }
    }, 3000);
})();
