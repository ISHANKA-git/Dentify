/*-----------------------------------*\
  #style.css
\*-----------------------------------*/




/*-----------------------------------*\
  #CUSTOM PROPERTY
\*-----------------------------------*/

:root {

    /**
    colors
    **/

    --light-steel-blue: hsl(218, 33%, 77%);
    --royal-blue-light: hsl(225, 68%, 53%);
    --flickr-blue_30: hsla(225, 68%, 53%, 0.3);
    --carolina-blue: hsl(201, 92%, 47%);
    --oxford-blue-1: hsl(218, 70%, 18%);
    --oxford-blue-2: hsl(217, 100%, 12%);
    --oxford-blue-3: hsl(218, 71%, 11%);
    --gainsboro_50: hsla(0, 0%, 85%, 0.5);
    --lavender-web: hsl(225, 67%, 91%);
    --sonic-silver: hsl(0, 0%, 47%);
    --light-gray: hsl(0, 0%, 84%);
    --cultured: hsl(0, 0%, 97%);
    --black_10: hsla(0, 0%, 0%, 0.1);
    --black_8: hsla(0, 0%, 0%, 0.08);
    --white: hsl(0, 0%, 100%);
    --black: hsl(0, 0%, 0%);
    --jet: hsl(0, 0%, 20%);
}

    /** Gradiant color **/

    --gradient: linear-gradient( 90deg, var(--carolina-blue) 0%, var(--royal-blue-light) 100%);

    /** typography **/

    --ff-roboto: "Roboto", sans-serif;
    --ff-poppins: "Poppins", sans-serif;

    --fs-1: 4rem;
    --fs-2: 3.6rem;
    --fs-3: 3.2rem;
    --fs-4: 2.4rem;
    --fs-5: 2.2rem;
    --fs-6: 1.8rem;
    --fs-7: 1.6rem;

    --fw-800: 800;
    --fw-700: 700;
    --fw-600: 600;
    --fw-500: 500;

    /** spacing **/

    --section-padding: 120px;

    /** Shadow **/

    --shadow-1: 4px 4px 15px var(--black_10);
    --shadow-2: 0 10px 15px var(--black_10);
    --shadow-3: 0px 20px 60px var(--black_8);
    --shadow-4: 0px 10px 30px var(--flickr-blue_30);
    --shadow-5: 0px 2px 60px 0px var(--black_10);

    /** Border Radius **/

    --radius-6: 6px;
    --radius-4: 4px;

    /** Transition **/

    --transition: 0.25s ease;
    --cubic-out: cubic-bezier(0.33, 0.85, 0.4, 0.96);

/*-----------------------------------*\
  #RESET
\*-----------------------------------*/

*,
*::before,
*::after {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

li { list-style: none; }

a {
  text-decoration: none;
  color: inherit;
}

a,
img,
span,
input,
button,
ion-icon { display: block; }

img { height: auto; }

input,
button {
  background: none;
  border: none;
  font: inherit;
}

input { width: 100%; }

button { cursor: pointer; }

ion-icon { pointer-events: none; }

address { font-style: normal; }

html {
  font-family: var(--ff-roboto);
  font-size: 10px;
  scroll-behavior: smooth;
}

body {
  background-color: var(--white);
  color: var(--sonic-silver);
  font-size: 1.5rem;
}






/*-----------------------------------*\
  #REUSED STYLE
\*-----------------------------------*/





/*-----------------------------------*\
  #HEDER
\*-----------------------------------*/





/*-----------------------------------*\
  #HERO
\*-----------------------------------*/





/*-----------------------------------*\
  #SERVICE
\*-----------------------------------*/





/*-----------------------------------*\
  #ABOUT
\*-----------------------------------*/





/*-----------------------------------*\
  #DOCTOR
\*-----------------------------------*/





/*-----------------------------------*\
  #CTA
\*-----------------------------------*/





/*-----------------------------------*\
  #BLOG
\*-----------------------------------*/





/*-----------------------------------*\
  #FOOTER
\*-----------------------------------*/





/*-----------------------------------*\
  #BACK TO TOP
\*-----------------------------------*/





/*-----------------------------------*\
  #MEDIA QUERIES
\*-----------------------------------*/