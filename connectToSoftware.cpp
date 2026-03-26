#include <stdio.h>
#include "pico/stdlib.h"




// define the api from the user such as 1 or 0 

void pico_set_led(bool led_on){
    gpio_put(25,led_on);
}


int main()
{
    stdio_init_all();

    if (user_input = 1 ){
        pico_set_led(true);
    }
    else if (user_input = 0){
        pico_set_led(false);
    }
}
