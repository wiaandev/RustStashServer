#!/bin/bash

# Define PostgreSQL connection parameters
PG_HOST="localhost"
PG_PORT="5432"
PG_USER="postgres"
PG_PASSWORD="E!1vmpwd"
DB_NAME="your_database_name"

# Drop the existing database
drop_database() {
    echo "Dropping existing database..."
    psql -h $PG_HOST -p $PG_PORT -U $PG_USER -c "DROP DATABASE IF EXISTS $DB_NAME;" > /dev/null 2>&1
}

# Create a new database
create_database() {
    echo "Creating new database..."
    psql -h $PG_HOST -p $PG_PORT -U $PG_USER -c "CREATE DATABASE $DB_NAME;" > /dev/null 2>&1
}

# Run EF Core migrations to update the database schema
run_migrations() {
    echo "Running EF Core migrations..."
    cd /path/to/your/dotnet/project
    dotnet ef database update --connection "Host=$PG_HOST;Port=$PG_PORT;Database=$DB_NAME;Username=$PG_USER;Password=$PG_PASSWORD;"
}

# Main function
main() {
    drop_database
    create_database
    run_migrations
}

# Execute main function
main
