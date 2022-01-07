let images = [];

for (let i = 0; i < 5; i++) {
    images[i] = document.getElementById("image"+ (i+1));
}

const nextImage = () => {
    for (let i = 0; i < images.length; i++) {
        images[i].addEventListener("mouseover", (event) => {
            event.target.src = "assets/images/image"+(i+1)+"_2.jpg";
        }, false);
    }
}

nextImage()