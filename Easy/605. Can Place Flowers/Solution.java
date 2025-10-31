class Solution {
    public boolean canPlaceFlowers(int[] flowerbed, int n) {
        boolean isPlantedNext =true;
        int plantableCounter =0;
        if(flowerbed.length ==1 && flowerbed[0] ==0) { plantableCounter++;}
        else{
            for(int i=0;i<flowerbed.length-1;i++){
                if(flowerbed[i] ==1){isPlantedNext=false;}
                else if(flowerbed[i]==0 && isPlantedNext && flowerbed[i+1] !=1){plantableCounter++; isPlantedNext=false;}
                else if(flowerbed[i]==0 && !isPlantedNext){isPlantedNext =true;}
                if(flowerbed[i+1]==0&& i== flowerbed.length-2 && isPlantedNext){plantableCounter++;}
                if(n<=plantableCounter) {break;}
            }
        }
        
        
        return (n<=plantableCounter);
    }
}