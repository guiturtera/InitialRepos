SET URL="https://github.com/guiturtera/CatalogoInstrumentosPresys.git"
SET REPOTOCREATE="CatalogoInstrumentosPresys"

mkdir %REPOTOCREATE%
cd %REPOTOCREATE%
git init
git remote add origin %URL%
git pull origin master
git remote remove origin
PAUSE