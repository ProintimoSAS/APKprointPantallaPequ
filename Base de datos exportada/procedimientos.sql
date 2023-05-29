use APKproint
----------------------------
CREATE PROCEDURE BuscarDatosPorModulo
    @nombreModulo VARCHAR(30),
    @tipoBusqueda VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    IF @tipoBusqueda = 'CodigoOrdenDeProduccion'
    BEGIN
        SELECT TOP 1 op.Codigo
        FROM tblOrdenDeProduccion op
        INNER JOIN tblModulo m ON op.idModulo = m.id
        WHERE m.Nombre = @nombreModulo
        ORDER BY op.id DESC
    END
    ELSE IF @tipoBusqueda = 'Referencia'
    BEGIN
        SELECT TOP 1 r.Codigo
        FROM tblReferencia r
        INNER JOIN tblPedido p ON r.idPedido = p.id
        INNER JOIN tblOrdenDeProduccion op ON r.id = op.idReferencia
        INNER JOIN tblModulo m ON op.idModulo = m.id
        WHERE m.Nombre = @nombreModulo
        ORDER BY op.id DESC
    END
    ELSE IF @tipoBusqueda = 'Pedido'
    BEGIN
        SELECT TOP 1 c.Nombre as Cliente
        FROM tblCliente c
        INNER JOIN tblPedido p ON c.id = p.idCliente
        INNER JOIN tblReferencia r ON p.id = r.idPedido
        INNER JOIN tblOrdenDeProduccion op ON r.id = op.idReferencia
        INNER JOIN tblModulo m ON op.idModulo = m.id
        WHERE m.Nombre = @nombreModulo
        ORDER BY op.id DESC
    END
    ELSE IF @tipoBusqueda = 'Cliente'
    BEGIN
        SELECT TOP 1 c.Nombre
        FROM tblCliente c
        INNER JOIN tblPedido p ON c.id = p.idCliente
        INNER JOIN tblReferencia r ON p.id = r.idPedido
        INNER JOIN tblOrdenDeProduccion op ON r.id = op.idReferencia
        INNER JOIN tblModulo m ON op.idModulo = m.id
        WHERE m.Nombre = @nombreModulo
        ORDER BY op.id DESC
    END
END


CREATE PROCEDURE VerDatosDeTodasLasTablas
AS
BEGIN
  SELECT 'tblCliente' AS Tabla, id, Nombre, NIT
  FROM tblCliente
  UNION
  SELECT 'tblPedido' AS Tabla, id, Codigo, idCliente
  FROM tblPedido
  UNION
  SELECT 'tblReferencia' AS Tabla, id, Codigo, Color, Descripcion, FechaCreacion, UnidadesTotalesAFabricar, idPedido
  FROM tblReferencia
  UNION
  SELECT 'tblModulo' AS Tabla, id, Nombre
  FROM tblModulo
  UNION
  SELECT 'tblOrdenDeProduccion' AS Tabla, id, Codigo, UnidadesAFabricar, Sam, Talla, idModulo, idReferencia
  FROM tblOrdenDeProduccion
  UNION
  SELECT 'tblProduccionModulo' AS Tabla, id, CantidadPersonas, Fecha, Hora, UnidadesFaltantes, UnidadesFabricadas, TiempoPrenda, NoConformes, PorcentajeParcial, PorcentajeAcumulado, UnidadesPorHora, Revision, idOrdenDeProduccion
  FROM tblProduccionModulo
END
