def main():
    from random import randint
    oldFile = open("C:\\test\\14agregarViaje.txt","r")
    oldFile2 = open("C:\\test\\13agregarRutaPorParada.txt","r")
    #newFile = open("C:\\test\\15agregarPasajero2.txt","w")
    newFile = open("C:\\test\\15pasajeros.txt","w")
    paradasPorRuta = []
    #Ciclo para agregar paradas
    for i in range(100):
        paradas = []
        
        if i+1 < 10:
            paradas.append(int(oldFile2.readline()[2:]))
            paradas.append(int(oldFile2.readline()[2:]))
        elif i+1 >= 10 and i+1 < 100:
            paradas.append(int(oldFile2.readline()[3:]))
            paradas.append(int(oldFile2.readline()[3:]))
        elif i+1 == 100:
            paradas.append(int(oldFile2.readline()[4:]))
            paradas.append(int(oldFile2.readline()[4:]))
        
        
        
        paradasPorRuta.append(paradas)
        for j in range(8):
            line = oldFile2.readline()
    

    
    for i in range(1000000):
        usuarios = []
        line = oldFile.readline()[-15:-11]+"\n"
        if "|" in line:
            pos = line.index("|")
            line = line[pos+1:]
            ruta = int(line)-1
        usuario = randint(100000001,100010000)
        
        for j in range(2):
            while usuario in usuarios:
                usuario = randint(100000001,100010000)
            usuarios.append(usuario)
            newFile.write(str(usuario)+"|"+str(paradasPorRuta[ruta][0])+"|"+str(paradasPorRuta[ruta][1])+"|"+str(i+1)+"\n")
    
        #newFile.write(str(paradasPorRuta[ruta])+"\n")        
        
    
    newFile.close()
    oldFile.close()
    oldFile2.close()

if __name__ == "__main__":
    main()
