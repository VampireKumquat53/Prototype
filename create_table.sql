drop if exists asset;

create table asset(
	assetID INT(11) NOT NULL PRIMARY KEY,
	deviceName VARCHAR(100) NOT NULL,
	model VARCHAR(50) NOT NULL,
	manufacturer VARCHAR(30) NOT NULL,
	type VARCHAR(30) NOT NULL,
	ipAddress VARCHAR(15) NOT NULL,
	purchaseDate DATE,
	note VARCHAR(250)
);