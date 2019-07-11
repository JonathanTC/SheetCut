using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SheetCut
{
    class Serializer
    {
        private DataContractJsonSerializerSettings _settings;
        private MemoryStream _flux;
        private DataContractJsonSerializer _serializer;
        private XmlDictionaryWriter _writer;
        private StreamReader _lecteurFlux;

        public Serializer()
        {
            // paramétrage
            _settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

            // ouverture d'un flux et creation du serializer
            _flux = new MemoryStream();
            _serializer = new DataContractJsonSerializer(typeof(Object), _settings);

            // recrutement de l'écrivain
            _writer = JsonReaderWriterFactory.CreateJsonWriter(_flux, Encoding.UTF8, false, true, "    ");

            // creation du lecteur de flux
            _lecteurFlux = new StreamReader(_flux);
        }

        public void Serialize(string pPath, object pObject)
        {
            _serializer.WriteObject(_writer, pObject);
            _writer.Flush();

            // initialiser la position au début du flux
            _flux.Position = 0;

            // écriture du flux dans un fichier
            File.WriteAllText(pPath, _lecteurFlux.ReadToEnd());
        }

        public object Unserialize(string pPath)
        {
            var fluxFichier = File.OpenRead(pPath);  
            return _serializer.ReadObject(fluxFichier);
        }
    }
}
