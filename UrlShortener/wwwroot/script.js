document.getElementById('urlForm').addEventListener('submit', async function (e) {
    e.preventDefault();

    const urlInput = document.getElementById('urlInput').value;
    const resultDiv = document.getElementById('result');
    const originalUrlSpan = document.getElementById('originalUrl');
    const shortUrlLink = document.getElementById('shortUrl');

    try {
        // POST request to shorten the URL
        const response = await fetch('/api/Url', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ url: urlInput })
        });

        if (!response.ok) {
            throw new Error(`Error: ${response.status} - ${await response.text()}`);
        }

        const data = await response.json();

        // Display results
        originalUrlSpan.textContent = data.originalUrl;
        shortUrlLink.textContent = data.shortUrl;
        shortUrlLink.href = data.shortUrl;
        resultDiv.classList.remove('hidden');
    } catch (error) {
        alert('Failed to shorten URL: ' + error.message);
        resultDiv.classList.add('hidden');
    }
});